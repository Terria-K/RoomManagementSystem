namespace RoomManagementSystem
{
    partial class SignUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPage));
            panel2 = new Panel();
            tbl_UserID = new TableLayoutPanel();
            tBox_UserID = new TextBox();
            lbl_UserID = new Label();
            tblLayout_LName = new TableLayoutPanel();
            tBox_LName = new TextBox();
            lbl_LName = new Label();
            tblLayout_FName = new TableLayoutPanel();
            tBox_FName = new TextBox();
            lbl_FName = new Label();
            tblLayout_MName = new TableLayoutPanel();
            tBox_MName = new TextBox();
            lbl_MName = new Label();
            tblLayout_userType = new TableLayoutPanel();
            lbl_UserType = new Label();
            cBox_UserType = new ComboBox();
            tblLayout_UserPassword = new TableLayoutPanel();
            tBox_Password = new TextBox();
            lbl_Password = new Label();
            tblLayout_ComfirmPassword = new TableLayoutPanel();
            tBox_ComfirmPassword = new TextBox();
            lbl_ComfirmPassword = new Label();
            tblLayout_Buttons = new TableLayoutPanel();
            cBox_ShowPassword = new CheckBox();
            btn_SignUp = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_SignPage = new Label();
            panel2.SuspendLayout();
            tbl_UserID.SuspendLayout();
            tblLayout_LName.SuspendLayout();
            tblLayout_FName.SuspendLayout();
            tblLayout_MName.SuspendLayout();
            tblLayout_userType.SuspendLayout();
            tblLayout_UserPassword.SuspendLayout();
            tblLayout_ComfirmPassword.SuspendLayout();
            tblLayout_Buttons.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(241, 241, 251);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbl_UserID);
            panel2.Controls.Add(tblLayout_LName);
            panel2.Controls.Add(tblLayout_FName);
            panel2.Controls.Add(tblLayout_MName);
            panel2.Controls.Add(tblLayout_userType);
            panel2.Controls.Add(tblLayout_UserPassword);
            panel2.Controls.Add(tblLayout_ComfirmPassword);
            panel2.Controls.Add(tblLayout_Buttons);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(13, 13);
            panel2.Margin = new Padding(3, 6, 3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 11, 10, 11);
            panel2.Size = new Size(373, 592);
            panel2.TabIndex = 3;
            // 
            // tbl_UserID
            // 
            tbl_UserID.ColumnCount = 1;
            tbl_UserID.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbl_UserID.Controls.Add(tBox_UserID, 0, 1);
            tbl_UserID.Controls.Add(lbl_UserID, 0, 0);
            tbl_UserID.Location = new Point(39, 87);
            tbl_UserID.Margin = new Padding(3, 11, 3, 3);
            tbl_UserID.Name = "tbl_UserID";
            tbl_UserID.RowCount = 2;
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tbl_UserID.Size = new Size(293, 53);
            tbl_UserID.TabIndex = 13;
            // 
            // tBox_UserID
            // 
            tBox_UserID.Dock = DockStyle.Fill;
            tBox_UserID.Location = new Point(10, 29);
            tBox_UserID.Margin = new Padding(10, 3, 10, 3);
            tBox_UserID.Name = "tBox_UserID";
            tBox_UserID.Size = new Size(273, 23);
            tBox_UserID.TabIndex = 1;
            // 
            // lbl_UserID
            // 
            lbl_UserID.AutoSize = true;
            lbl_UserID.Dock = DockStyle.Left;
            lbl_UserID.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserID.Location = new Point(3, 0);
            lbl_UserID.Name = "lbl_UserID";
            lbl_UserID.Size = new Size(55, 26);
            lbl_UserID.TabIndex = 1;
            lbl_UserID.Text = "User ID: *";
            lbl_UserID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblLayout_LName
            // 
            tblLayout_LName.ColumnCount = 1;
            tblLayout_LName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout_LName.Controls.Add(tBox_LName, 0, 1);
            tblLayout_LName.Controls.Add(lbl_LName, 0, 0);
            tblLayout_LName.Location = new Point(39, 145);
            tblLayout_LName.Margin = new Padding(3, 6, 3, 3);
            tblLayout_LName.Name = "tblLayout_LName";
            tblLayout_LName.RowCount = 2;
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_LName.Size = new Size(293, 53);
            tblLayout_LName.TabIndex = 8;
            // 
            // tBox_LName
            // 
            tBox_LName.Dock = DockStyle.Fill;
            tBox_LName.Location = new Point(10, 29);
            tBox_LName.Margin = new Padding(10, 3, 10, 3);
            tBox_LName.Name = "tBox_LName";
            tBox_LName.Size = new Size(273, 23);
            tBox_LName.TabIndex = 1;
            // 
            // lbl_LName
            // 
            lbl_LName.AutoSize = true;
            lbl_LName.Dock = DockStyle.Left;
            lbl_LName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_LName.Location = new Point(3, 0);
            lbl_LName.Name = "lbl_LName";
            lbl_LName.Size = new Size(70, 26);
            lbl_LName.TabIndex = 1;
            lbl_LName.Text = "Last Name: *";
            lbl_LName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblLayout_FName
            // 
            tblLayout_FName.ColumnCount = 1;
            tblLayout_FName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout_FName.Controls.Add(tBox_FName, 0, 1);
            tblLayout_FName.Controls.Add(lbl_FName, 0, 0);
            tblLayout_FName.Location = new Point(39, 203);
            tblLayout_FName.Margin = new Padding(3, 6, 3, 3);
            tblLayout_FName.Name = "tblLayout_FName";
            tblLayout_FName.RowCount = 2;
            tblLayout_FName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_FName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_FName.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_FName.Size = new Size(293, 53);
            tblLayout_FName.TabIndex = 11;
            // 
            // tBox_FName
            // 
            tBox_FName.Dock = DockStyle.Fill;
            tBox_FName.Location = new Point(10, 29);
            tBox_FName.Margin = new Padding(10, 3, 10, 3);
            tBox_FName.Name = "tBox_FName";
            tBox_FName.Size = new Size(273, 23);
            tBox_FName.TabIndex = 1;
            // 
            // lbl_FName
            // 
            lbl_FName.AutoSize = true;
            lbl_FName.Dock = DockStyle.Left;
            lbl_FName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FName.Location = new Point(3, 0);
            lbl_FName.Name = "lbl_FName";
            lbl_FName.Size = new Size(72, 26);
            lbl_FName.TabIndex = 1;
            lbl_FName.Text = "First Name: *";
            lbl_FName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblLayout_MName
            // 
            tblLayout_MName.ColumnCount = 1;
            tblLayout_MName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout_MName.Controls.Add(tBox_MName, 0, 1);
            tblLayout_MName.Controls.Add(lbl_MName, 0, 0);
            tblLayout_MName.Location = new Point(39, 262);
            tblLayout_MName.Margin = new Padding(3, 6, 3, 3);
            tblLayout_MName.Name = "tblLayout_MName";
            tblLayout_MName.RowCount = 2;
            tblLayout_MName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_MName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_MName.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_MName.Size = new Size(293, 53);
            tblLayout_MName.TabIndex = 9;
            // 
            // tBox_MName
            // 
            tBox_MName.Dock = DockStyle.Fill;
            tBox_MName.Location = new Point(10, 29);
            tBox_MName.Margin = new Padding(10, 3, 10, 3);
            tBox_MName.Name = "tBox_MName";
            tBox_MName.Size = new Size(273, 23);
            tBox_MName.TabIndex = 1;
            // 
            // lbl_MName
            // 
            lbl_MName.AutoSize = true;
            lbl_MName.Dock = DockStyle.Left;
            lbl_MName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MName.Location = new Point(3, 0);
            lbl_MName.Name = "lbl_MName";
            lbl_MName.Size = new Size(78, 26);
            lbl_MName.TabIndex = 1;
            lbl_MName.Text = "Middle Name:";
            lbl_MName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblLayout_userType
            // 
            tblLayout_userType.ColumnCount = 1;
            tblLayout_userType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout_userType.Controls.Add(lbl_UserType, 0, 0);
            tblLayout_userType.Controls.Add(cBox_UserType, 0, 1);
            tblLayout_userType.Location = new Point(39, 320);
            tblLayout_userType.Margin = new Padding(3, 6, 3, 3);
            tblLayout_userType.Name = "tblLayout_userType";
            tblLayout_userType.RowCount = 2;
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_userType.Size = new Size(293, 53);
            tblLayout_userType.TabIndex = 12;
            // 
            // lbl_UserType
            // 
            lbl_UserType.AutoSize = true;
            lbl_UserType.Dock = DockStyle.Left;
            lbl_UserType.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserType.Location = new Point(3, 0);
            lbl_UserType.Name = "lbl_UserType";
            lbl_UserType.Size = new Size(66, 26);
            lbl_UserType.TabIndex = 1;
            lbl_UserType.Text = "User Type: *";
            lbl_UserType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cBox_UserType
            // 
            cBox_UserType.FormattingEnabled = true;
            cBox_UserType.Items.AddRange(new object[] { "STUDENT", "INSTRUCTOR", "ADMIN" });
            cBox_UserType.Location = new Point(10, 29);
            cBox_UserType.Margin = new Padding(10, 3, 10, 3);
            cBox_UserType.Name = "cBox_UserType";
            cBox_UserType.Size = new Size(156, 23);
            cBox_UserType.TabIndex = 1;
            cBox_UserType.Text = "Select User Type";
            // 
            // tblLayout_UserPassword
            // 
            tblLayout_UserPassword.ColumnCount = 1;
            tblLayout_UserPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayout_UserPassword.Controls.Add(tBox_Password, 0, 1);
            tblLayout_UserPassword.Controls.Add(lbl_Password, 0, 0);
            tblLayout_UserPassword.Location = new Point(39, 380);
            tblLayout_UserPassword.Margin = new Padding(3, 6, 3, 3);
            tblLayout_UserPassword.Name = "tblLayout_UserPassword";
            tblLayout_UserPassword.RowCount = 2;
            tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_UserPassword.Size = new Size(293, 53);
            tblLayout_UserPassword.TabIndex = 10;
            // 
            // tBox_Password
            // 
            tBox_Password.Dock = DockStyle.Fill;
            tBox_Password.Location = new Point(10, 29);
            tBox_Password.Margin = new Padding(10, 3, 10, 3);
            tBox_Password.Name = "tBox_Password";
            tBox_Password.Size = new Size(273, 23);
            tBox_Password.TabIndex = 1;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Dock = DockStyle.Left;
            lbl_Password.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(3, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(67, 26);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password: *";
            lbl_Password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblLayout_ComfirmPassword
            // 
            tblLayout_ComfirmPassword.ColumnCount = 1;
            tblLayout_ComfirmPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayout_ComfirmPassword.Controls.Add(tBox_ComfirmPassword, 0, 1);
            tblLayout_ComfirmPassword.Controls.Add(lbl_ComfirmPassword, 0, 0);
            tblLayout_ComfirmPassword.Location = new Point(39, 438);
            tblLayout_ComfirmPassword.Margin = new Padding(3, 6, 3, 3);
            tblLayout_ComfirmPassword.Name = "tblLayout_ComfirmPassword";
            tblLayout_ComfirmPassword.RowCount = 2;
            tblLayout_ComfirmPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_ComfirmPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_ComfirmPassword.Size = new Size(293, 53);
            tblLayout_ComfirmPassword.TabIndex = 9;
            // 
            // tBox_ComfirmPassword
            // 
            tBox_ComfirmPassword.Dock = DockStyle.Fill;
            tBox_ComfirmPassword.Location = new Point(10, 29);
            tBox_ComfirmPassword.Margin = new Padding(10, 3, 10, 3);
            tBox_ComfirmPassword.Name = "tBox_ComfirmPassword";
            tBox_ComfirmPassword.Size = new Size(273, 23);
            tBox_ComfirmPassword.TabIndex = 1;
            // 
            // lbl_ComfirmPassword
            // 
            lbl_ComfirmPassword.AutoSize = true;
            lbl_ComfirmPassword.Dock = DockStyle.Left;
            lbl_ComfirmPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ComfirmPassword.Location = new Point(3, 0);
            lbl_ComfirmPassword.Name = "lbl_ComfirmPassword";
            lbl_ComfirmPassword.Size = new Size(113, 26);
            lbl_ComfirmPassword.TabIndex = 3;
            lbl_ComfirmPassword.Text = "Comfirm Password: *";
            lbl_ComfirmPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblLayout_Buttons
            // 
            tblLayout_Buttons.ColumnCount = 1;
            tblLayout_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout_Buttons.Controls.Add(cBox_ShowPassword, 0, 0);
            tblLayout_Buttons.Controls.Add(btn_SignUp, 0, 1);
            tblLayout_Buttons.Location = new Point(39, 497);
            tblLayout_Buttons.Name = "tblLayout_Buttons";
            tblLayout_Buttons.RowCount = 2;
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblLayout_Buttons.Size = new Size(293, 61);
            tblLayout_Buttons.TabIndex = 5;
            // 
            // cBox_ShowPassword
            // 
            cBox_ShowPassword.AutoSize = true;
            cBox_ShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBox_ShowPassword.Location = new Point(10, 3);
            cBox_ShowPassword.Margin = new Padding(10, 3, 10, 3);
            cBox_ShowPassword.Name = "cBox_ShowPassword";
            cBox_ShowPassword.Size = new Size(107, 17);
            cBox_ShowPassword.TabIndex = 1;
            cBox_ShowPassword.Text = "Show Password";
            cBox_ShowPassword.UseVisualStyleBackColor = true;
            cBox_ShowPassword.CheckedChanged += cBox_ShowPassword_CheckedChanged;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.CornflowerBlue;
            btn_SignUp.Dock = DockStyle.Bottom;
            btn_SignUp.Location = new Point(56, 29);
            btn_SignUp.Margin = new Padding(56, 3, 56, 3);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(181, 29);
            btn_SignUp.TabIndex = 1;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lbl_SignPage, 0, 0);
            tableLayoutPanel2.Location = new Point(39, 31);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.Size = new Size(293, 49);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // lbl_SignPage
            // 
            lbl_SignPage.AutoSize = true;
            lbl_SignPage.Dock = DockStyle.Fill;
            lbl_SignPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SignPage.Location = new Point(3, 0);
            lbl_SignPage.Name = "lbl_SignPage";
            lbl_SignPage.Size = new Size(287, 49);
            lbl_SignPage.TabIndex = 7;
            lbl_SignPage.Text = "Sign Up Page";
            lbl_SignPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 67);
            ClientSize = new Size(400, 617);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignUpPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up Page";
            Load += SignUpPage_Load;
            panel2.ResumeLayout(false);
            tbl_UserID.ResumeLayout(false);
            tbl_UserID.PerformLayout();
            tblLayout_LName.ResumeLayout(false);
            tblLayout_LName.PerformLayout();
            tblLayout_FName.ResumeLayout(false);
            tblLayout_FName.PerformLayout();
            tblLayout_MName.ResumeLayout(false);
            tblLayout_MName.PerformLayout();
            tblLayout_userType.ResumeLayout(false);
            tblLayout_userType.PerformLayout();
            tblLayout_UserPassword.ResumeLayout(false);
            tblLayout_UserPassword.PerformLayout();
            tblLayout_ComfirmPassword.ResumeLayout(false);
            tblLayout_ComfirmPassword.PerformLayout();
            tblLayout_Buttons.ResumeLayout(false);
            tblLayout_Buttons.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tblLayout_UserPassword;
        private System.Windows.Forms.TextBox tBox_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TableLayoutPanel tblLayout_ComfirmPassword;
        private System.Windows.Forms.TextBox tBox_ComfirmPassword;
        private System.Windows.Forms.Label lbl_ComfirmPassword;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Buttons;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.CheckBox cBox_ShowPassword;
        private System.Windows.Forms.TableLayoutPanel tblLayout_LName;
        private System.Windows.Forms.TextBox tBox_LName;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_SignPage;
        private System.Windows.Forms.TableLayoutPanel tblLayout_FName;
        private System.Windows.Forms.TextBox tBox_FName;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TableLayoutPanel tblLayout_MName;
        private System.Windows.Forms.TextBox tBox_MName;
        private System.Windows.Forms.Label lbl_MName;
        private System.Windows.Forms.TableLayoutPanel tblLayout_userType;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.ComboBox cBox_UserType;
        private System.Windows.Forms.TableLayoutPanel tbl_UserID;
        private System.Windows.Forms.TextBox tBox_UserID;
        private System.Windows.Forms.Label lbl_UserID;
    }
}