namespace Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboRooms = new ComboBox();
            dgvSchedules = new DataGridView();
            groupBox1 = new GroupBox();
            btnDel = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            btnAdd = new Button();
            cboTimeSlots = new ComboBox();
            cboMovies = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 167);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "List Of Rooms";
            // 
            // cboRooms
            // 
            cboRooms.FormattingEnabled = true;
            cboRooms.Location = new Point(130, 164);
            cboRooms.Name = "cboRooms";
            cboRooms.Size = new Size(126, 23);
            cboRooms.TabIndex = 1;
            cboRooms.TextChanged += cboRooms_TextChanged;
            // 
            // dgvSchedules
            // 
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(34, 216);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowTemplate.Height = 25;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(627, 314);
            dgvSchedules.TabIndex = 2;
            dgvSchedules.CellClick += dgvSchedules_CellClick;
            dgvSchedules.CellDoubleClick += dgvSchedules_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDel);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cboTimeSlots);
            groupBox1.Controls.Add(cboMovies);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(693, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 327);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Schedule";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(141, 254);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(114, 23);
            btnDel.TabIndex = 11;
            btnDel.Text = "Delete Schedule";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDelete_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(97, 204);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(158, 23);
            dtpEndDate.TabIndex = 10;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(97, 144);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(158, 23);
            dtpStartDate.TabIndex = 9;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboTimeSlots
            // 
            cboTimeSlots.FormattingEnabled = true;
            cboTimeSlots.Location = new Point(97, 95);
            cboTimeSlots.Name = "cboTimeSlots";
            cboTimeSlots.Size = new Size(158, 23);
            cboTimeSlots.TabIndex = 5;
            // 
            // cboMovies
            // 
            cboMovies.FormattingEnabled = true;
            cboMovies.Location = new Point(93, 43);
            cboMovies.Name = "cboMovies";
            cboMovies.Size = new Size(162, 23);
            cboMovies.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 204);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 150);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 2;
            label4.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 98);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Time Slot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 43);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Movie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(271, 41);
            label6.Name = "label6";
            label6.Size = new Size(484, 54);
            label6.TabIndex = 4;
            label6.Text = "Manage Movie Schedule";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 137);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 5;
            label7.Text = "Search (Movie)";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(348, 164);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(184, 23);
            txtSearchValue.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(547, 163);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 555);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(txtSearchValue);
            Controls.Add(dgvSchedules);
            Controls.Add(cboRooms);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboRooms;
        private DataGridView dgvSchedules;
        private GroupBox groupBox1;
        private Button btnAdd;
        private ComboBox cboTimeSlots;
        private ComboBox cboMovies;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label6;
        private Label label7;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Button btnDel;
    }
}
