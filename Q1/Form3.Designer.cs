namespace Q1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtScheduleId = new TextBox();
            txtNote = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            cboRooms = new ComboBox();
            cboMovies = new ComboBox();
            cboTimeSlots = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Schedule ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 118);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Movie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 162);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "TimeSlot";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 205);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "StartDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 246);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "EndDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 286);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 6;
            label7.Text = "Note";
            // 
            // txtScheduleId
            // 
            txtScheduleId.Location = new Point(117, 30);
            txtScheduleId.Name = "txtScheduleId";
            txtScheduleId.ReadOnly = true;
            txtScheduleId.Size = new Size(200, 23);
            txtScheduleId.TabIndex = 7;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(117, 283);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 23);
            txtNote.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(50, 334);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(224, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboRooms
            // 
            cboRooms.FormattingEnabled = true;
            cboRooms.Location = new Point(117, 72);
            cboRooms.Name = "cboRooms";
            cboRooms.Size = new Size(121, 23);
            cboRooms.TabIndex = 16;
            // 
            // cboMovies
            // 
            cboMovies.FormattingEnabled = true;
            cboMovies.Location = new Point(117, 115);
            cboMovies.Name = "cboMovies";
            cboMovies.Size = new Size(167, 23);
            cboMovies.TabIndex = 17;
            // 
            // cboTimeSlots
            // 
            cboTimeSlots.FormattingEnabled = true;
            cboTimeSlots.Location = new Point(117, 159);
            cboTimeSlots.Name = "cboTimeSlots";
            cboTimeSlots.Size = new Size(200, 23);
            cboTimeSlots.TabIndex = 18;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(117, 199);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 19;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(117, 240);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 20;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 389);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cboTimeSlots);
            Controls.Add(cboMovies);
            Controls.Add(cboRooms);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtNote);
            Controls.Add(txtScheduleId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtScheduleId;
        private TextBox txtNote;
        private Button btnUpdate;
        private Button btnCancel;
        private ComboBox cboRooms;
        private ComboBox cboMovies;
        private ComboBox cboTimeSlots;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
    }
}