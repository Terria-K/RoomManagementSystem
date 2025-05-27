﻿namespace RoomManagementSystem.Components
{
    partial class RoomControl
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
            panel1 = new Panel();
            text = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // text
            // 
            text.AutoSize = true;
            text.BackColor = Color.Transparent;
            text.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text.ForeColor = SystemColors.Control;
            text.Location = new Point(17, 62);
            text.Name = "text";
            text.Size = new Size(116, 25);
            text.TabIndex = 0;
            text.Text = "Placeholder";
            text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoomControl
            // 
            BackColor = Color.Gray;
            Controls.Add(text);
            Name = "RoomControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label text;
    }
}
