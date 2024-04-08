using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private Models.View returnView;

        bool search = false;

        IEnumerable<Schedule> dataSource;

        PePrnFall2023B1Context context = new PePrnFall2023B1Context();
        public Form1()
        {
            InitializeComponent();
            Load();
            LoadSchedule();
        }

        private void Load()
        {
            List<Room> rooms = context.Rooms.ToList();
            List<Movie> movies = context.Movies.ToList();
            List<TimeSlot> timeSlots = context.TimeSlots.ToList();


            // Create a new Room object for "All" with Id as 0
            Room allRoom = new Room { Id = 0, Title = "All" };
            // Prepend the "All" room to the rooms list
            rooms.Insert(0, allRoom);

            cboRooms.DataSource = rooms;
            cboMovies.DataSource = movies;
            cboTimeSlots.DataSource = timeSlots;

            cboRooms.DisplayMember = "Title";
            cboRooms.ValueMember = "Id";

            cboMovies.DisplayMember = "Title";
            cboMovies.ValueMember = "Id";

            cboTimeSlots.DisplayMember = "TimeString";
            cboTimeSlots.ValueMember = "Id";
        }

        private void LoadSchedule()
        {
            List<Schedule> schedules = context.Schedules
                .Include(x => x.Room).Include(x => x.Movie).Include(x => x.TimeSlot)
                .ToList();

            if (search)
            {
                schedules = dataSource.ToList();
                cboRooms.SelectedIndex = 0;
            }
            else if ((cboRooms.SelectedItem as Room).Id != 0)
            {
                schedules = schedules.Where(x => x.RoomId == (cboRooms.SelectedItem as Room).Id).ToList();
                search = false;
            }

            dgvSchedules.DataSource = schedules.ToList().Select(x => new
            {
                x.Id,
                x.Room.Title,
                Movie = (x.Movie != null) ? x.Movie.Title : "",
                TimeSlot = (x.TimeSlot != null) ? (x.TimeSlot.TimeString) : "",
                x.StartDate,
                x.EndDate,
                x.Note
            }).ToList();
        }

        private void cboRooms_TextChanged(object sender, EventArgs e)
        {
            search = false;
            txtSearchValue.Clear();
            LoadSchedule();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            int roomId = ((Room)cboRooms.SelectedItem).Id;
            int slotId = ((TimeSlot)cboTimeSlots.SelectedItem).Id;
            int movieId = ((Movie)cboMovies.SelectedItem).Id;

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                check = true;
            }

            if (roomId==0)
            {
                MessageBox.Show("Please choose room in List Of Rooms");
                return;
            }

            if (check)
            {
                MessageBox.Show("The screening schedule does not meet the conditions and cannot be added to the database");
                return;
            }
            else
            {
                Schedule schedule = new Schedule();
                schedule.MovieId = movieId;
                schedule.RoomId = roomId;
                schedule.TimeSlotId = slotId;
                schedule.StartDate = dtpStartDate.Value;
                schedule.EndDate = dtpEndDate.Value;

                search = false;

                context.Schedules.Add(schedule);
                context.SaveChanges();
                LoadSchedule();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtSearchValue.Text;
                
                IEnumerable<Schedule> searchResult = context.SearchMember(searchName);
                if (searchResult.Any())
                {
                    dataSource = searchResult;
                    search = true;
                    LoadSchedule();
                }
                else
                {
                    MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not the header row and it's within the row boundaries
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the DataGridViewRow corresponding to the clicked cell
                DataGridViewRow selectedRow = dgvSchedules.Rows[e.RowIndex];

                // Retrieve the data object associated with the row
                if (selectedRow.DataBoundItem != null)
                {
                    Models.View a = new Models.View();
                    String inputString = selectedRow.DataBoundItem.ToString();

                    inputString = inputString.TrimStart('{').TrimEnd('}');
                    string[] propertyAssignments = inputString.Split(',');

                    foreach (string assignment in propertyAssignments)
                    {
                        // Split the assignment into property name and value
                        string[] parts = assignment.Trim().Split('=');
                        string propertyName = parts[0].Trim();
                        string propertyValue = parts[1].Trim().TrimStart('"').TrimEnd('"'); // Remove leading and trailing quotes

                        // Assign values based on property name
                        switch (propertyName)
                        {
                            case "Id":
                                a.Id = int.Parse(propertyValue);
                                break;
                            case "Title":
                                a.RoomTitle = propertyValue;
                                break;
                            case "Movie":
                                a.MovieTitle = propertyValue;
                                break;
                            case "TimeSlot":
                                a.TimeSlot = propertyValue;
                                break;
                            case "StartDate":
                                a.StartDate = DateTime.Parse(propertyValue);
                                break;
                            case "EndDate":
                                a.EndDate = DateTime.Parse(propertyValue);
                                break;
                            case "Note":
                                a.Note = propertyValue;
                                break;
                        }
                    }

                    returnView = a;
                }
                else
                {
                    MessageBox.Show("No object associated with this row.");
                }
            }
            else
            {
                MessageBox.Show("Select in table");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (returnView == null)
            {
                MessageBox.Show("Please choose item !!", "Delete schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Do you really want to delete the schedule ? \n" +
                $"Schedule ID: {returnView.Id}\n" +
                $"Room: {returnView.RoomTitle}\n" +
                $"Movie: {returnView.MovieTitle}\n" +
                $"TimeSlot: {returnView.TimeSlot}\n" +
                $"StartDate: {returnView.StartDate}\n" +
                $"EndDate: {returnView.EndDate}\n" +
                $"Note: {returnView.Note}", "Delete schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    search = false;
                    context.Delete(returnView.Id);
                    context.SaveChanges();
                    LoadSchedule();
                }
            }
        }

        private void dgvSchedules_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 frm3 = new Form3
            {
                viewInfo = returnView,
                Text = "Update schedule info"
            };
            if (frm3.ShowDialog() == DialogResult.OK)
            {
                search = false;
                LoadSchedule();
            }
        }
        
    }
}
