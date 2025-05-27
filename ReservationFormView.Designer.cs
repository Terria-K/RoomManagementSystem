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
            SuspendLayout();
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            text1.Location = new Point(288, 36);
            text1.Name = "text1";
            text1.Size = new Size(59, 21);
            text1.TabIndex = 0;
            text1.Text = "Room:";
            // 
            // roomNameText
            // 
            roomNameText.AutoSize = true;
            roomNameText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            roomNameText.Location = new Point(383, 36);
            roomNameText.Name = "roomNameText";
            roomNameText.Size = new Size(108, 21);
            roomNameText.TabIndex = 1;
            roomNameText.Text = "Room_Name";
            // 
            // instructorText
            // 
            instructorText.AutoSize = true;
            instructorText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            instructorText.Location = new Point(383, 79);
            instructorText.Name = "instructorText";
            instructorText.Size = new Size(130, 21);
            instructorText.TabIndex = 3;
            instructorText.Text = "InstructorName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(288, 79);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Instructor:";
            // 
            // timeInText
            // 
            timeInText.AutoSize = true;
            timeInText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            timeInText.Location = new Point(383, 164);
            timeInText.Name = "timeInText";
            timeInText.Size = new Size(109, 21);
            timeInText.TabIndex = 5;
            timeInText.Text = "TimeInName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(288, 164);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 4;
            label3.Text = "Time In:";
            // 
            // timeOutText
            // 
            timeOutText.AutoSize = true;
            timeOutText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            timeOutText.Location = new Point(383, 202);
            timeOutText.Name = "timeOutText";
            timeOutText.Size = new Size(122, 21);
            timeOutText.TabIndex = 7;
            timeOutText.Text = "TimeOutName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(288, 202);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 6;
            label4.Text = "Time out:";
            // 
            // sectionText
            // 
            sectionText.AutoSize = true;
            sectionText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sectionText.Location = new Point(383, 122);
            sectionText.Name = "sectionText";
            sectionText.Size = new Size(113, 21);
            sectionText.TabIndex = 9;
            sectionText.Text = "SectionName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(288, 122);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 8;
            label5.Text = "Section:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(366, 239);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 10;
            label6.Text = "Reason:";
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(12, 274);
            reasonBox.MaxLength = 200;
            reasonBox.Multiline = true;
            reasonBox.Name = "reasonBox";
            reasonBox.ReadOnly = true;
            reasonBox.Size = new Size(776, 150);
            reasonBox.TabIndex = 11;
            // 
            // ReservationFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(reasonBox);
            Controls.Add(label6);
            Controls.Add(sectionText);
            Controls.Add(label5);
            Controls.Add(timeOutText);
            Controls.Add(label4);
            Controls.Add(timeInText);
            Controls.Add(label3);
            Controls.Add(instructorText);
            Controls.Add(label2);
            Controls.Add(roomNameText);
            Controls.Add(text1);
            Name = "ReservationFormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservationFormView";
            Load += OnViewLoad;
            ResumeLayout(false);
            PerformLayout();
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
    }
}