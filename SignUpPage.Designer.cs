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
            panel2.Location = new Point(15, 17);
            panel2.Margin = new Padding(3, 8, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(11, 15, 11, 15);
            panel2.Size = new Size(426, 789);
            panel2.TabIndex = 3;
            // 
            // tbl_UserID
            // 
            tbl_UserID.ColumnCount = 1;
            tbl_UserID.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbl_UserID.Controls.Add(tBox_UserID, 0, 1);
            tbl_UserID.Controls.Add(lbl_UserID, 0, 0);
            tbl_UserID.Location = new Point(45, 116);
            tbl_UserID.Margin = new Padding(3, 15, 3, 4);
            tbl_UserID.Name = "tbl_UserID";
            tbl_UserID.RowCount = 2;
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tbl_UserID.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tbl_UserID.Size = new Size(335, 71);
            tbl_UserID.TabIndex = 13;
            // 
            // tBox_UserID
            // 
            tBox_UserID.Dock = DockStyle.Fill;
            tBox_UserID.Location = new Point(11, 39);
            tBox_UserID.Margin = new Padding(11, 4, 11, 4);
            tBox_UserID.Name = "tBox_UserID";
            tBox_UserID.Size = new Size(313, 27);
            tBox_UserID.TabIndex = 1;
            // 
            // lbl_UserID
            // 
            lbl_UserID.AutoSize = true;
            lbl_UserID.Dock = DockStyle.Left;
            lbl_UserID.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserID.Location = new Point(3, 0);
            lbl_UserID.Name = "lbl_UserID";
            lbl_UserID.Size = new Size(63, 35);
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
            tblLayout_LName.Location = new Point(45, 193);
            tblLayout_LName.Margin = new Padding(3, 8, 3, 4);
            tblLayout_LName.Name = "tblLayout_LName";
            tblLayout_LName.RowCount = 2;
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_LName.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_LName.Size = new Size(335, 71);
            tblLayout_LName.TabIndex = 8;
            // 
            // tBox_LName
            // 
            tBox_LName.Dock = DockStyle.Fill;
            tBox_LName.Location = new Point(11, 39);
            tBox_LName.Margin = new Padding(11, 4, 11, 4);
            tBox_LName.Name = "tBox_LName";
            tBox_LName.Size = new Size(313, 27);
            tBox_LName.TabIndex = 1;
            // 
            // lbl_LName
            // 
            lbl_LName.AutoSize = true;
            lbl_LName.Dock = DockStyle.Left;
            lbl_LName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_LName.Location = new Point(3, 0);
            lbl_LName.Name = "lbl_LName";
            lbl_LName.Size = new Size(82, 35);
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
            tblLayout_FName.Location = new Point(45, 271);
            tblLayout_FName.Margin = new Padding(3, 8, 3, 4);
            tblLayout_FName.Name = "tblLayout_FName";
            tblLayout_FName.RowCount = 2;
            tblLayout_FName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_FName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_FName.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_FName.Size = new Size(335, 71);
            tblLayout_FName.TabIndex = 11;
            // 
            // tBox_FName
            // 
            tBox_FName.Dock = DockStyle.Fill;
            tBox_FName.Location = new Point(11, 39);
            tBox_FName.Margin = new Padding(11, 4, 11, 4);
            tBox_FName.Name = "tBox_FName";
            tBox_FName.Size = new Size(313, 27);
            tBox_FName.TabIndex = 1;
            // 
            // lbl_FName
            // 
            lbl_FName.AutoSize = true;
            lbl_FName.Dock = DockStyle.Left;
            lbl_FName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FName.Location = new Point(3, 0);
            lbl_FName.Name = "lbl_FName";
            lbl_FName.Size = new Size(83, 35);
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
            tblLayout_MName.Location = new Point(45, 349);
            tblLayout_MName.Margin = new Padding(3, 8, 3, 4);
            tblLayout_MName.Name = "tblLayout_MName";
            tblLayout_MName.RowCount = 2;
            tblLayout_MName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_MName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_MName.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_MName.Size = new Size(335, 71);
            tblLayout_MName.TabIndex = 9;
            // 
            // tBox_MName
            // 
            tBox_MName.Dock = DockStyle.Fill;
            tBox_MName.Location = new Point(11, 39);
            tBox_MName.Margin = new Padding(11, 4, 11, 4);
            tBox_MName.Name = "tBox_MName";
            tBox_MName.Size = new Size(313, 27);
            tBox_MName.TabIndex = 1;
            // 
            // lbl_MName
            // 
            lbl_MName.AutoSize = true;
            lbl_MName.Dock = DockStyle.Left;
            lbl_MName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MName.Location = new Point(3, 0);
            lbl_MName.Name = "lbl_MName";
            lbl_MName.Size = new Size(91, 35);
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
            tblLayout_userType.Location = new Point(45, 427);
            tblLayout_userType.Margin = new Padding(3, 8, 3, 4);
            tblLayout_userType.Name = "tblLayout_userType";
            tblLayout_userType.RowCount = 2;
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_userType.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_userType.Size = new Size(335, 71);
            tblLayout_userType.TabIndex = 12;
            // 
            // lbl_UserType
            // 
            lbl_UserType.AutoSize = true;
            lbl_UserType.Dock = DockStyle.Left;
            lbl_UserType.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserType.Location = new Point(3, 0);
            lbl_UserType.Name = "lbl_UserType";
            lbl_UserType.Size = new Size(78, 35);
            lbl_UserType.TabIndex = 1;
            lbl_UserType.Text = "User Type: *";
            lbl_UserType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cBox_UserType
            // 
            cBox_UserType.FormattingEnabled = true;
            cBox_UserType.Items.AddRange(new object[] { "STUDENT", "INSTRUCTOR", "ADMIN" });
            cBox_UserType.Location = new Point(11, 39);
            cBox_UserType.Margin = new Padding(11, 4, 11, 4);
            cBox_UserType.Name = "cBox_UserType";
            cBox_UserType.Size = new Size(178, 28);
            cBox_UserType.TabIndex = 1;
            cBox_UserType.Text = "Select User Type";
            // 
            // tblLayout_UserPassword
            // 
            tblLayout_UserPassword.ColumnCount = 1;
            tblLayout_UserPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayout_UserPassword.Controls.Add(tBox_Password, 0, 1);
            tblLayout_UserPassword.Controls.Add(lbl_Password, 0, 0);
            tblLayout_UserPassword.Location = new Point(45, 507);
            tblLayout_UserPassword.Margin = new Padding(3, 8, 3, 4);
            tblLayout_UserPassword.Name = "tblLayout_UserPassword";
            tblLayout_UserPassword.RowCount = 2;
            tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_UserPassword.Size = new Size(335, 71);
            tblLayout_UserPassword.TabIndex = 10;
            // 
            // tBox_Password
            // 
            tBox_Password.Dock = DockStyle.Fill;
            tBox_Password.Location = new Point(11, 39);
            tBox_Password.Margin = new Padding(11, 4, 11, 4);
            tBox_Password.Name = "tBox_Password";
            tBox_Password.Size = new Size(313, 27);
            tBox_Password.TabIndex = 1;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Dock = DockStyle.Left;
            lbl_Password.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(3, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(76, 35);
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
            tblLayout_ComfirmPassword.Location = new Point(45, 584);
            tblLayout_ComfirmPassword.Margin = new Padding(3, 8, 3, 4);
            tblLayout_ComfirmPassword.Name = "tblLayout_ComfirmPassword";
            tblLayout_ComfirmPassword.RowCount = 2;
            tblLayout_ComfirmPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_ComfirmPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout_ComfirmPassword.Size = new Size(335, 71);
            tblLayout_ComfirmPassword.TabIndex = 9;
            // 
            // tBox_ComfirmPassword
            // 
            tBox_ComfirmPassword.Dock = DockStyle.Fill;
            tBox_ComfirmPassword.Location = new Point(11, 39);
            tBox_ComfirmPassword.Margin = new Padding(11, 4, 11, 4);
            tBox_ComfirmPassword.Name = "tBox_ComfirmPassword";
            tBox_ComfirmPassword.Size = new Size(313, 27);
            tBox_ComfirmPassword.TabIndex = 1;
            // 
            // lbl_ComfirmPassword
            // 
            lbl_ComfirmPassword.AutoSize = true;
            lbl_ComfirmPassword.Dock = DockStyle.Left;
            lbl_ComfirmPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ComfirmPassword.Location = new Point(3, 0);
            lbl_ComfirmPassword.Name = "lbl_ComfirmPassword";
            lbl_ComfirmPassword.Size = new Size(130, 35);
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
            tblLayout_Buttons.Location = new Point(45, 663);
            tblLayout_Buttons.Margin = new Padding(3, 4, 3, 4);
            tblLayout_Buttons.Name = "tblLayout_Buttons";
            tblLayout_Buttons.RowCount = 2;
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_Buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblLayout_Buttons.Size = new Size(335, 81);
            tblLayout_Buttons.TabIndex = 5;
            // 
            // cBox_ShowPassword
            // 
            cBox_ShowPassword.AutoSize = true;
            cBox_ShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBox_ShowPassword.Location = new Point(11, 4);
            cBox_ShowPassword.Margin = new Padding(11, 4, 11, 4);
            cBox_ShowPassword.Name = "cBox_ShowPassword";
            cBox_ShowPassword.Size = new Size(121, 21);
            cBox_ShowPassword.TabIndex = 1;
            cBox_ShowPassword.Text = "Show Password";
            cBox_ShowPassword.UseVisualStyleBackColor = true;
            cBox_ShowPassword.CheckedChanged += cBox_ShowPassword_CheckedChanged;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.CornflowerBlue;
            btn_SignUp.Dock = DockStyle.Bottom;
            btn_SignUp.Location = new Point(64, 39);
            btn_SignUp.Margin = new Padding(64, 4, 64, 4);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(207, 38);
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
            tableLayoutPanel2.Location = new Point(45, 41);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Size = new Size(335, 65);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // lbl_SignPage
            // 
            lbl_SignPage.AutoSize = true;
            lbl_SignPage.Dock = DockStyle.Fill;
            lbl_SignPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SignPage.Location = new Point(3, 0);
            lbl_SignPage.Name = "lbl_SignPage";
            lbl_SignPage.Size = new Size(329, 65);
            lbl_SignPage.TabIndex = 7;
            lbl_SignPage.Text = "Sign Up Page";
            lbl_SignPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 67);
            ClientSize = new Size(457, 823);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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