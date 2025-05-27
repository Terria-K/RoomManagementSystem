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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            dateBox = new DateTimePicker();
            dateLabel = new Label();
            timeOutBox = new ComboBox();
            label2 = new Label();
            sectionBox = new TextBox();
            timeInBox = new ComboBox();
            roomList = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            instructorName = new Label();
            button1 = new Button();
            reasonBox = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 241, 251);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(reasonBox);
            panel1.Location = new Point(4, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 491);
            panel1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8837214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6046524F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.263566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.55814F));
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(dateBox, 1, 2);
            tableLayoutPanel1.Controls.Add(dateLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(timeOutBox, 3, 3);
            tableLayoutPanel1.Controls.Add(label2, 2, 3);
            tableLayoutPanel1.Controls.Add(sectionBox, 1, 4);
            tableLayoutPanel1.Controls.Add(timeInBox, 1, 3);
            tableLayoutPanel1.Controls.Add(roomList, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(instructorName, 1, 1);
            tableLayoutPanel1.Location = new Point(26, 21);
            tableLayoutPanel1.Margin = new Padding(24, 24, 24, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6813183F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846149F));
            tableLayoutPanel1.Size = new Size(645, 273);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 29;
            label7.Text = "Room: *";
            // 
            // dateBox
            // 
            dateBox.Location = new Point(98, 94);
            dateBox.Margin = new Padding(3, 4, 3, 4);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(242, 27);
            dateBox.TabIndex = 32;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(3, 90);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 20);
            dateLabel.TabIndex = 33;
            dateLabel.Text = "Date:";
            // 
            // timeOutBox
            // 
            timeOutBox.FormattingEnabled = true;
            timeOutBox.Location = new Point(437, 139);
            timeOutBox.Margin = new Padding(3, 4, 3, 4);
            timeOutBox.Name = "timeOutBox";
            timeOutBox.Size = new Size(149, 28);
            timeOutBox.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 135);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 21;
            label2.Text = "Time Out: *";
            // 
            // sectionBox
            // 
            sectionBox.Location = new Point(98, 184);
            sectionBox.Margin = new Padding(3, 4, 3, 4);
            sectionBox.MaxLength = 20;
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(149, 27);
            sectionBox.TabIndex = 26;
            // 
            // timeInBox
            // 
            timeInBox.FormattingEnabled = true;
            timeInBox.Location = new Point(98, 139);
            timeInBox.Margin = new Padding(3, 4, 3, 4);
            timeInBox.Name = "timeInBox";
            timeInBox.Size = new Size(149, 28);
            timeInBox.TabIndex = 20;
            // 
            // roomList
            // 
            roomList.FormattingEnabled = true;
            roomList.Location = new Point(98, 4);
            roomList.Margin = new Padding(3, 4, 3, 4);
            roomList.Name = "roomList";
            roomList.Size = new Size(149, 28);
            roomList.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 23;
            label3.Text = "Instructor: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 135);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 19;
            label1.Text = "Time In: *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 180);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 25;
            label5.Text = "Section: *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 230);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 27;
            label6.Text = "Reason: *";
            // 
            // instructorName
            // 
            instructorName.AutoSize = true;
            instructorName.Location = new Point(98, 45);
            instructorName.Name = "instructorName";
            instructorName.Size = new Size(95, 20);
            instructorName.TabIndex = 24;
            instructorName.Text = "Lorem Ipsum";
            // 
            // button1
            // 
            button1.Location = new Point(276, 439);
            button1.Margin = new Padding(12);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 31;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = true;
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(29, 294);
            reasonBox.Margin = new Padding(24, 0, 24, 12);
            reasonBox.MaxLength = 200;
            reasonBox.Multiline = true;
            reasonBox.Name = "reasonBox";
            reasonBox.Size = new Size(639, 132);
            reasonBox.TabIndex = 28;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 67);
            ClientSize = new Size(710, 513);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ReservationForm";
            Padding = new Padding(7, 8, 7, 8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Form";
            Load += OnFormLoad;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label dateLabel;
        private DateTimePicker dateBox;
        private Button button1;
        private ComboBox roomList;
        private Label label7;
        private TextBox reasonBox;
        private Label label6;
        private TextBox sectionBox;
        private Label label5;
        private Label instructorName;
        private Label label3;
        private ComboBox timeOutBox;
        private Label label2;
        private ComboBox timeInBox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}