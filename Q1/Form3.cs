using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Q1
{
    public partial class Form3 : Form
    {
        PePrnFall2023B1Context context = new PePrnFall2023B1Context();
        public Models.View viewInfo { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Room> rooms = context.Rooms.ToList();
            List<Movie> movies = context.Movies.ToList();
            List<TimeSlot> timeSlots = context.TimeSlots.ToList();

            cboRooms.DataSource = rooms;
            cboMovies.DataSource = movies;
            cboTimeSlots.DataSource = timeSlots;

            cboRooms.DisplayMember = "Title";
            cboRooms.ValueMember = "Id";

            cboMovies.DisplayMember = "Title";
            cboMovies.ValueMember = "Id";

            cboTimeSlots.DisplayMember = "TimeString";
            cboTimeSlots.ValueMember = "Id";

            Schedule schedule = context.GetSchedule(viewInfo.Id);

            txtScheduleId.Text = schedule.Id.ToString();
            SelectItemById1(schedule.RoomId);
            SelectItemById2(schedule.MovieId);
            SelectItemById3(schedule.TimeSlotId??0);
            dtpStartDate.Value = schedule.StartDate;
            dtpEndDate.Value = schedule.EndDate;
            txtNote.Text = schedule.Note;
        }

        private void SelectItemById1(int id)
        {
            foreach (Room item in cboRooms.Items)
            {
                if (item.Id == id)
                {
                    cboRooms.SelectedItem = item;
                    return; // Exit loop once item is found
                }
            }
        }

        private void SelectItemById2(int id)
        {
            foreach (Movie item in cboMovies.Items)
            {
                if (item.Id == id)
                {
                    cboMovies.SelectedItem = item;
                    return; // Exit loop once item is found
                }
            }
        }

        private void SelectItemById3(int id)
        {
            foreach (TimeSlot item in cboTimeSlots.Items)
            {
                if (item.Id == id)
                {
                    cboTimeSlots.SelectedItem = item;
                    return; // Exit loop once item is found
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int roomId = ((Room)cboRooms.SelectedItem).Id;
            int slotId = ((TimeSlot)cboTimeSlots.SelectedItem).Id;
            int movieId = ((Movie)cboMovies.SelectedItem).Id;

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("The screening schedule does not meet the conditions and cannot be added to the database");
                return;
            }
            else
            {
                Schedule schedule = new Schedule();
                schedule.Id = Convert.ToInt32(txtScheduleId.Text); 
                schedule.MovieId = movieId;
                schedule.RoomId = roomId;
                schedule.TimeSlotId = slotId;
                schedule.StartDate = dtpStartDate.Value;
                schedule.EndDate = dtpEndDate.Value;
                schedule.Note = txtNote.Text;

                context.UpdateSchedule(schedule);
                MessageBox.Show("Update successfully!!", "Update schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();           
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
