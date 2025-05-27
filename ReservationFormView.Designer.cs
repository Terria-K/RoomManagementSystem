namespace RoomManagementSystem
{
    partial class ReservationFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationFormView));
            text1 = new Label();
            roomNameText = new Label();
            instructorText = new Label();
            label2 = new Label();
            timeInText = new Label();
            label3 = new Label();
            timeOutText = new Label();
            label4 = new Label();
            sectionText = new Label();
            label5 = new Label();
            label6 = new Label();
            reasonBox = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            text1.Location = new Point(3, 0);
            text1.Name = "text1";
            text1.Size = new Size(60, 23);
            text1.TabIndex = 0;
            text1.Text = "Room:";
            // 
            // roomNameText
            // 
            roomNameText.AutoSize = true;
            roomNameText.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            roomNameText.Location = new Point(177, 0);
            roomNameText.Name = "roomNameText";
            roomNameText.Size = new Size(109, 23);
            roomNameText.TabIndex = 1;
            roomNameText.Text = "Room_Name";
            // 
            // instructorText
            // 
            instructorText.AutoSize = true;
            instructorText.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            instructorText.Location = new Point(177, 44);
            instructorText.Name = "instructorText";
            instructorText.Size = new Size(130, 23);
            instructorText.TabIndex = 3;
            instructorText.Text = "InstructorName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 2;
            label2.Text = "Instructor:";
            // 
            // timeInText
            // 
            timeInText.AutoSize = true;
            timeInText.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            timeInText.Location = new Point(177, 132);
            timeInText.Name = "timeInText";
            timeInText.Size = new Size(108, 23);
            timeInText.TabIndex = 5;
            timeInText.Text = "TimeInName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 4;
            label3.Text = "Time In:";
            // 
            // timeOutText
            // 
            timeOutText.AutoSize = true;
            timeOutText.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            timeOutText.Location = new Point(177, 176);
            timeOutText.Name = "timeOutText";
            timeOutText.Size = new Size(122, 23);
            timeOutText.TabIndex = 7;
            timeOutText.Text = "TimeOutName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 176);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 6;
            label4.Text = "Time out:";
            // 
            // sectionText
            // 
            sectionText.AutoSize = true;
            sectionText.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            sectionText.Location = new Point(177, 88);
            sectionText.Name = "sectionText";
            sectionText.Size = new Size(112, 23);
            sectionText.TabIndex = 9;
            sectionText.Text = "SectionName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(3, 88);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 8;
            label5.Text = "Section:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(3, 220);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 10;
            label6.Text = "Reason:";
            // 
            // reasonBox
            // 
            reasonBox.BorderStyle = BorderStyle.FixedSingle;
            reasonBox.Location = new Point(24, 287);
            reasonBox.Margin = new Padding(24, 4, 24, 4);
            reasonBox.MaxLength = 200;
            reasonBox.Multiline = true;
            reasonBox.Name = "reasonBox";
            reasonBox.ReadOnly = true;
            reasonBox.Size = new Size(664, 196);
            reasonBox.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 241, 251);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(reasonBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 513);
            panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(text1, 0, 0);
            tableLayoutPanel1.Controls.Add(timeOutText, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(timeInText, 1, 3);
            tableLayoutPanel1.Controls.Add(sectionText, 1, 2);
            tableLayoutPanel1.Controls.Add(roomNameText, 1, 0);
            tableLayoutPanel1.Controls.Add(instructorText, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Location = new Point(24, 24);
            tableLayoutPanel1.Margin = new Padding(3, 24, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(348, 264);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // ReservationFormView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 67);
            ClientSize = new Size(736, 537);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ReservationFormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Form View";
            Load += OnViewLoad;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label text1;
        private Label roomNameText;
        private Label instructorText;
        private Label label2;
        private Label timeInText;
        private Label label3;
        private Label timeOutText;
        private Label label4;
        private Label sectionText;
        private Label label5;
        private Label label6;
        private TextBox reasonBox;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}