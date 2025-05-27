namespace RoomManagementSystem
{
    partial class ReservationForm
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
            timeInBox = new ComboBox();
            label1 = new Label();
            timeOutBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            instructorName = new Label();
            label5 = new Label();
            sectionBox = new TextBox();
            label6 = new Label();
            reasonBox = new TextBox();
            label7 = new Label();
            roomList = new ComboBox();
            button1 = new Button();
            dateBox = new DateTimePicker();
            dateLabel = new Label();
            SuspendLayout();
            // 
            // timeInBox
            // 
            timeInBox.FormattingEnabled = true;
            timeInBox.Location = new Point(78, 132);
            timeInBox.Name = "timeInBox";
            timeInBox.Size = new Size(121, 23);
            timeInBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 135);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Time In: *";
            // 
            // timeOutBox
            // 
            timeOutBox.FormattingEnabled = true;
            timeOutBox.Location = new Point(304, 132);
            timeOutBox.Name = "timeOutBox";
            timeOutBox.Size = new Size(121, 23);
            timeOutBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 135);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Time Out: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 66);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 7;
            label3.Text = "Instructor: ";
            // 
            // instructorName
            // 
            instructorName.AutoSize = true;
            instructorName.Location = new Point(78, 66);
            instructorName.Name = "instructorName";
            instructorName.Size = new Size(77, 15);
            instructorName.TabIndex = 8;
            instructorName.Text = "Lorem Ipsum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 161);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Section: *";
            // 
            // sectionBox
            // 
            sectionBox.Location = new Point(18, 179);
            sectionBox.MaxLength = 20;
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(187, 23);
            sectionBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 215);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Reason: *";
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(18, 233);
            reasonBox.MaxLength = 200;
            reasonBox.Multiline = true;
            reasonBox.Name = "reasonBox";
            reasonBox.Size = new Size(626, 100);
            reasonBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 32);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Room: *";
            // 
            // roomList
            // 
            roomList.FormattingEnabled = true;
            roomList.Location = new Point(78, 29);
            roomList.Name = "roomList";
            roomList.Size = new Size(121, 23);
            roomList.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(278, 339);
            button1.Name = "button1";
            button1.Size = new Size(97, 37);
            button1.TabIndex = 15;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnReserveClicked;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(78, 93);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(200, 23);
            dateBox.TabIndex = 16;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(18, 99);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 15);
            dateLabel.TabIndex = 17;
            dateLabel.Text = "Date:";
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 385);
            Controls.Add(dateLabel);
            Controls.Add(dateBox);
            Controls.Add(button1);
            Controls.Add(roomList);
            Controls.Add(label7);
            Controls.Add(reasonBox);
            Controls.Add(label6);
            Controls.Add(sectionBox);
            Controls.Add(label5);
            Controls.Add(instructorName);
            Controls.Add(label3);
            Controls.Add(timeOutBox);
            Controls.Add(label2);
            Controls.Add(timeInBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReservationForm";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Form";
            Load += OnFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox timeInBox;
        private Label label1;
        private ComboBox timeOutBox;
        private Label label2;
        private Label label3;
        private Label instructorName;
        private Label label5;
        private TextBox sectionBox;
        private Label label6;
        private TextBox reasonBox;
        private Label label7;
        private ComboBox roomList;
        private Button button1;
        private DateTimePicker dateBox;
        private Label dateLabel;
    }
}