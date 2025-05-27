namespace RoomManagementSystem
{
    partial class UC_Floor5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel18 = new Panel();
            roomControl8 = new RoomManagementSystem.Components.RoomControl();
            roomControl7 = new RoomManagementSystem.Components.RoomControl();
            roomControl6 = new RoomManagementSystem.Components.RoomControl();
            roomControl5 = new RoomManagementSystem.Components.RoomControl();
            roomControl4 = new RoomManagementSystem.Components.RoomControl();
            roomControl3 = new RoomManagementSystem.Components.RoomControl();
            roomControl2 = new RoomManagementSystem.Components.RoomControl();
            roomControl1 = new RoomManagementSystem.Components.RoomControl();
            panel18.SuspendLayout();
            SuspendLayout();
            // 
            // panel18
            // 
            panel18.BackColor = Color.Transparent;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(roomControl8);
            panel18.Controls.Add(roomControl7);
            panel18.Controls.Add(roomControl6);
            panel18.Controls.Add(roomControl5);
            panel18.Controls.Add(roomControl4);
            panel18.Controls.Add(roomControl3);
            panel18.Controls.Add(roomControl2);
            panel18.Controls.Add(roomControl1);
            panel18.Location = new Point(3, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(790, 639);
            panel18.TabIndex = 62;
            // 
            // roomControl8
            // 
            roomControl8.BackColor = Color.Red;
            roomControl8.Location = new Point(341, 2);
            roomControl8.Name = "roomControl8";
            roomControl8.RoomID = "gym";
            roomControl8.RoomName = "Gym";
            roomControl8.Size = new Size(448, 636);
            roomControl8.TabIndex = 77;
            // 
            // roomControl7
            // 
            roomControl7.BackColor = Color.Gray;
            roomControl7.Location = new Point(187, 3);
            roomControl7.Name = "roomControl7";
            roomControl7.RoomID = "fireExitStairs";
            roomControl7.RoomName = "Stairs";
            roomControl7.Size = new Size(150, 90);
            roomControl7.TabIndex = 76;
            roomControl7.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // roomControl6
            // 
            roomControl6.BackColor = Color.Gray;
            roomControl6.Location = new Point(185, 128);
            roomControl6.Name = "roomControl6";
            roomControl6.RoomID = "maleCR";
            roomControl6.RoomName = "Male CR";
            roomControl6.Size = new Size(150, 63);
            roomControl6.TabIndex = 75;
            roomControl6.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // roomControl5
            // 
            roomControl5.BackColor = Color.Gray;
            roomControl5.Location = new Point(115, 30);
            roomControl5.Name = "roomControl5";
            roomControl5.RoomID = "femaleCR";
            roomControl5.RoomName = "F CR";
            roomControl5.Size = new Size(66, 161);
            roomControl5.TabIndex = 74;
            roomControl5.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // roomControl4
            // 
            roomControl4.BackColor = Color.Gray;
            roomControl4.Location = new Point(115, 428);
            roomControl4.Name = "roomControl4";
            roomControl4.RoomID = "elevatedBleachers";
            roomControl4.RoomName = "Elevated Bleachers";
            roomControl4.Size = new Size(221, 210);
            roomControl4.TabIndex = 73;
            roomControl4.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // roomControl3
            // 
            roomControl3.BackColor = Color.Gray;
            roomControl3.Location = new Point(115, 197);
            roomControl3.Name = "roomControl3";
            roomControl3.RoomID = "facultySHS";
            roomControl3.RoomName = "Faculty SHS";
            roomControl3.Size = new Size(221, 109);
            roomControl3.TabIndex = 72;
            roomControl3.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // roomControl2
            // 
            roomControl2.BackColor = Color.Gray;
            roomControl2.Location = new Point(-1, 196);
            roomControl2.Name = "roomControl2";
            roomControl2.RoomID = "elevator";
            roomControl2.RoomName = "Elevator";
            roomControl2.Size = new Size(110, 109);
            roomControl2.TabIndex = 71;
            roomControl2.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // roomControl1
            // 
            roomControl1.BackColor = Color.Gray;
            roomControl1.Location = new Point(-1, 428);
            roomControl1.Name = "roomControl1";
            roomControl1.RoomID = "stairsTo4th";
            roomControl1.RoomName = "Stairs";
            roomControl1.Size = new Size(110, 209);
            roomControl1.TabIndex = 70;
            roomControl1.Type = Components.RoomControl.RoomType.Miscellanous;
            // 
            // UC_Floor5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel18);
            Margin = new Padding(0);
            Name = "UC_Floor5";
            Size = new Size(1103, 749);
            Load += UC_Floor5_Load;
            panel18.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private Components.RoomControl roomControl4;
        private Components.RoomControl roomControl3;
        private Components.RoomControl roomControl2;
        private Components.RoomControl roomControl1;
        private Components.RoomControl roomControl8;
        private Components.RoomControl roomControl7;
        private Components.RoomControl roomControl6;
        private Components.RoomControl roomControl5;
    }
}
