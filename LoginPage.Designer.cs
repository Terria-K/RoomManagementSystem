﻿namespace RoomManagementSystem;

partial class LoginPage
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
        panel2 = new Panel();
        panel1 = new Panel();
        ipBox = new TextBox();
        btnIP = new Button();
        tblLayout_SignUp = new TableLayoutPanel();
        lbl_SignUp = new Label();
        tblLayout_Splitter = new TableLayoutPanel();
        lbl_3 = new Label();
        lbl_2 = new Label();
        lbl_1 = new Label();
        tblLayout_UserPassword = new TableLayoutPanel();
        tBox_Password = new TextBox();
        lbl_Password = new Label();
        tblLayout_LoginButtons = new TableLayoutPanel();
        btn_Login = new Button();
        cBox_ShowPassword = new CheckBox();
        tblLayout_UserID = new TableLayoutPanel();
        tBox_UserID = new TextBox();
        lbl_UserID = new Label();
        tblLayout_Header = new TableLayoutPanel();
        lbl_LoginPage = new Label();
        picBox_LoginPageIcon = new PictureBox();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        tblLayout_SignUp.SuspendLayout();
        tblLayout_Splitter.SuspendLayout();
        tblLayout_UserPassword.SuspendLayout();
        tblLayout_LoginButtons.SuspendLayout();
        tblLayout_UserID.SuspendLayout();
        tblLayout_Header.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picBox_LoginPageIcon).BeginInit();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(241, 241, 251);
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(panel1);
        panel2.Controls.Add(tblLayout_SignUp);
        panel2.Controls.Add(tblLayout_Splitter);
        panel2.Controls.Add(tblLayout_UserPassword);
        panel2.Controls.Add(tblLayout_LoginButtons);
        panel2.Controls.Add(tblLayout_UserID);
        panel2.Controls.Add(tblLayout_Header);
        panel2.Location = new Point(13, 13);
        panel2.Margin = new Padding(3, 8, 3, 4);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(11, 15, 11, 15);
        panel2.Size = new Size(393, 594);
        panel2.TabIndex = 3;
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(ipBox);
        panel1.Controls.Add(btnIP);
        panel1.Location = new Point(67, 535);
        panel1.Name = "panel1";
        panel1.Size = new Size(257, 50);
        panel1.TabIndex = 14;
        // 
        // ipBox
        // 
        ipBox.Location = new Point(9, 12);
        ipBox.Margin = new Padding(12, 0, 3, 0);
        ipBox.Name = "ipBox";
        ipBox.Size = new Size(122, 27);
        ipBox.TabIndex = 12;
        ipBox.Text = "localhost";
        ipBox.TextChanged += ipBox_TextChanged;
        // 
        // btnIP
        // 
        btnIP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnIP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnIP.Location = new Point(137, 12);
        btnIP.Margin = new Padding(3, 0, 6, 0);
        btnIP.Name = "btnIP";
        btnIP.Size = new Size(109, 27);
        btnIP.TabIndex = 13;
        btnIP.Text = "Change IP";
        btnIP.UseVisualStyleBackColor = true;
        btnIP.Click += OnIPChange;
        // 
        // tblLayout_SignUp
        // 
        tblLayout_SignUp.ColumnCount = 1;
        tblLayout_SignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblLayout_SignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
        tblLayout_SignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
        tblLayout_SignUp.Controls.Add(lbl_SignUp, 0, 0);
        tblLayout_SignUp.Location = new Point(41, 491);
        tblLayout_SignUp.Margin = new Padding(3, 4, 3, 4);
        tblLayout_SignUp.Name = "tblLayout_SignUp";
        tblLayout_SignUp.RowCount = 1;
        tblLayout_SignUp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblLayout_SignUp.Size = new Size(311, 41);
        tblLayout_SignUp.TabIndex = 11;
        // 
        // lbl_SignUp
        // 
        lbl_SignUp.AutoSize = true;
        lbl_SignUp.Dock = DockStyle.Fill;
        lbl_SignUp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl_SignUp.Location = new Point(0, 0);
        lbl_SignUp.Margin = new Padding(0);
        lbl_SignUp.Name = "lbl_SignUp";
        lbl_SignUp.Size = new Size(311, 41);
        lbl_SignUp.TabIndex = 3;
        lbl_SignUp.Text = "Sign Up";
        lbl_SignUp.TextAlign = ContentAlignment.MiddleCenter;
        lbl_SignUp.Click += lbl_SignUp_Click;
        // 
        // tblLayout_Splitter
        // 
        tblLayout_Splitter.ColumnCount = 3;
        tblLayout_Splitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.85775F));
        tblLayout_Splitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28449F));
        tblLayout_Splitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.85776F));
        tblLayout_Splitter.Controls.Add(lbl_3, 2, 0);
        tblLayout_Splitter.Controls.Add(lbl_2, 1, 0);
        tblLayout_Splitter.Controls.Add(lbl_1, 0, 0);
        tblLayout_Splitter.Location = new Point(41, 449);
        tblLayout_Splitter.Margin = new Padding(3, 4, 3, 4);
        tblLayout_Splitter.Name = "tblLayout_Splitter";
        tblLayout_Splitter.RowCount = 1;
        tblLayout_Splitter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblLayout_Splitter.Size = new Size(311, 41);
        tblLayout_Splitter.TabIndex = 10;
        // 
        // lbl_3
        // 
        lbl_3.AutoSize = true;
        lbl_3.Dock = DockStyle.Fill;
        lbl_3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
        lbl_3.Location = new Point(180, 0);
        lbl_3.Name = "lbl_3";
        lbl_3.Size = new Size(128, 41);
        lbl_3.TabIndex = 5;
        lbl_3.Text = "        ";
        lbl_3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_2
        // 
        lbl_2.AutoSize = true;
        lbl_2.Dock = DockStyle.Fill;
        lbl_2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl_2.Location = new Point(136, 0);
        lbl_2.Name = "lbl_2";
        lbl_2.Size = new Size(38, 41);
        lbl_2.TabIndex = 4;
        lbl_2.Text = "or";
        lbl_2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_1
        // 
        lbl_1.AutoSize = true;
        lbl_1.Dock = DockStyle.Fill;
        lbl_1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
        lbl_1.Location = new Point(3, 0);
        lbl_1.Name = "lbl_1";
        lbl_1.Size = new Size(127, 41);
        lbl_1.TabIndex = 3;
        lbl_1.Text = "        ";
        lbl_1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tblLayout_UserPassword
        // 
        tblLayout_UserPassword.ColumnCount = 1;
        tblLayout_UserPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblLayout_UserPassword.Controls.Add(tBox_Password, 0, 1);
        tblLayout_UserPassword.Controls.Add(lbl_Password, 0, 0);
        tblLayout_UserPassword.Location = new Point(41, 276);
        tblLayout_UserPassword.Margin = new Padding(3, 4, 3, 4);
        tblLayout_UserPassword.Name = "tblLayout_UserPassword";
        tblLayout_UserPassword.RowCount = 3;
        tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tblLayout_UserPassword.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tblLayout_UserPassword.Size = new Size(311, 80);
        tblLayout_UserPassword.TabIndex = 9;
        // 
        // tBox_Password
        // 
        tBox_Password.Dock = DockStyle.Fill;
        tBox_Password.Location = new Point(3, 31);
        tBox_Password.Margin = new Padding(3, 4, 3, 4);
        tBox_Password.Name = "tBox_Password";
        tBox_Password.Size = new Size(305, 27);
        tBox_Password.TabIndex = 4;
        // 
        // lbl_Password
        // 
        lbl_Password.AutoSize = true;
        lbl_Password.Dock = DockStyle.Left;
        lbl_Password.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl_Password.Location = new Point(3, 0);
        lbl_Password.Name = "lbl_Password";
        lbl_Password.Size = new Size(67, 27);
        lbl_Password.TabIndex = 3;
        lbl_Password.Text = "Password:";
        lbl_Password.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tblLayout_LoginButtons
        // 
        tblLayout_LoginButtons.ColumnCount = 1;
        tblLayout_LoginButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblLayout_LoginButtons.Controls.Add(btn_Login, 0, 1);
        tblLayout_LoginButtons.Controls.Add(cBox_ShowPassword, 0, 0);
        tblLayout_LoginButtons.Location = new Point(41, 360);
        tblLayout_LoginButtons.Margin = new Padding(3, 4, 3, 4);
        tblLayout_LoginButtons.Name = "tblLayout_LoginButtons";
        tblLayout_LoginButtons.RowCount = 2;
        tblLayout_LoginButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tblLayout_LoginButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblLayout_LoginButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tblLayout_LoginButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tblLayout_LoginButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tblLayout_LoginButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tblLayout_LoginButtons.Size = new Size(311, 81);
        tblLayout_LoginButtons.TabIndex = 5;
        // 
        // btn_Login
        // 
        btn_Login.BackColor = Color.CornflowerBlue;
        btn_Login.Dock = DockStyle.Bottom;
        btn_Login.Location = new Point(64, 39);
        btn_Login.Margin = new Padding(64, 4, 64, 4);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new Size(183, 38);
        btn_Login.TabIndex = 4;
        btn_Login.Text = "Login";
        btn_Login.UseVisualStyleBackColor = false;
        btn_Login.Click += btn_Login_Click;
        // 
        // cBox_ShowPassword
        // 
        cBox_ShowPassword.AutoSize = true;
        cBox_ShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cBox_ShowPassword.Location = new Point(3, 4);
        cBox_ShowPassword.Margin = new Padding(3, 4, 3, 4);
        cBox_ShowPassword.Name = "cBox_ShowPassword";
        cBox_ShowPassword.Size = new Size(121, 21);
        cBox_ShowPassword.TabIndex = 5;
        cBox_ShowPassword.Text = "Show Password";
        cBox_ShowPassword.UseVisualStyleBackColor = true;
        cBox_ShowPassword.CheckedChanged += cBox_ShowPassword_CheckedChanged;
        // 
        // tblLayout_UserID
        // 
        tblLayout_UserID.ColumnCount = 1;
        tblLayout_UserID.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblLayout_UserID.Controls.Add(tBox_UserID, 0, 1);
        tblLayout_UserID.Controls.Add(lbl_UserID, 0, 0);
        tblLayout_UserID.Location = new Point(41, 189);
        tblLayout_UserID.Margin = new Padding(3, 4, 3, 4);
        tblLayout_UserID.Name = "tblLayout_UserID";
        tblLayout_UserID.RowCount = 2;
        tblLayout_UserID.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tblLayout_UserID.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tblLayout_UserID.Size = new Size(311, 80);
        tblLayout_UserID.TabIndex = 8;
        // 
        // tBox_UserID
        // 
        tBox_UserID.Dock = DockStyle.Fill;
        tBox_UserID.Location = new Point(3, 44);
        tBox_UserID.Margin = new Padding(3, 4, 3, 4);
        tBox_UserID.Name = "tBox_UserID";
        tBox_UserID.Size = new Size(305, 27);
        tBox_UserID.TabIndex = 2;
        // 
        // lbl_UserID
        // 
        lbl_UserID.AutoSize = true;
        lbl_UserID.Dock = DockStyle.Left;
        lbl_UserID.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl_UserID.Location = new Point(3, 0);
        lbl_UserID.Name = "lbl_UserID";
        lbl_UserID.Size = new Size(54, 40);
        lbl_UserID.TabIndex = 1;
        lbl_UserID.Text = "User ID:";
        lbl_UserID.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tblLayout_Header
        // 
        tblLayout_Header.ColumnCount = 1;
        tblLayout_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblLayout_Header.Controls.Add(lbl_LoginPage, 0, 0);
        tblLayout_Header.Controls.Add(picBox_LoginPageIcon, 0, 1);
        tblLayout_Header.Location = new Point(41, 25);
        tblLayout_Header.Margin = new Padding(3, 4, 3, 4);
        tblLayout_Header.Name = "tblLayout_Header";
        tblLayout_Header.RowCount = 2;
        tblLayout_Header.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblLayout_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tblLayout_Header.Size = new Size(311, 156);
        tblLayout_Header.TabIndex = 7;
        // 
        // lbl_LoginPage
        // 
        lbl_LoginPage.AutoSize = true;
        lbl_LoginPage.Dock = DockStyle.Fill;
        lbl_LoginPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl_LoginPage.Location = new Point(3, 0);
        lbl_LoginPage.Name = "lbl_LoginPage";
        lbl_LoginPage.Size = new Size(305, 40);
        lbl_LoginPage.TabIndex = 7;
        lbl_LoginPage.Text = "Login Page";
        lbl_LoginPage.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // picBox_LoginPageIcon
        // 
        picBox_LoginPageIcon.Anchor = AnchorStyles.None;
        picBox_LoginPageIcon.Image = (Image)resources.GetObject("picBox_LoginPageIcon.Image");
        picBox_LoginPageIcon.Location = new Point(110, 47);
        picBox_LoginPageIcon.Margin = new Padding(3, 4, 3, 4);
        picBox_LoginPageIcon.Name = "picBox_LoginPageIcon";
        picBox_LoginPageIcon.Size = new Size(90, 101);
        picBox_LoginPageIcon.TabIndex = 6;
        picBox_LoginPageIcon.TabStop = false;
        // 
        // LoginPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(48, 56, 67);
        ClientSize = new Size(418, 620);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new Size(436, 690);
        MinimizeBox = false;
        MinimumSize = new Size(436, 635);
        Name = "LoginPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login Page";
        Load += LoginPage_Load;
        panel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        tblLayout_SignUp.ResumeLayout(false);
        tblLayout_SignUp.PerformLayout();
        tblLayout_Splitter.ResumeLayout(false);
        tblLayout_Splitter.PerformLayout();
        tblLayout_UserPassword.ResumeLayout(false);
        tblLayout_UserPassword.PerformLayout();
        tblLayout_LoginButtons.ResumeLayout(false);
        tblLayout_LoginButtons.PerformLayout();
        tblLayout_UserID.ResumeLayout(false);
        tblLayout_UserID.PerformLayout();
        tblLayout_Header.ResumeLayout(false);
        tblLayout_Header.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picBox_LoginPageIcon).EndInit();
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tblLayout_SignUp;
    private System.Windows.Forms.Label lbl_SignUp;
    private System.Windows.Forms.TableLayoutPanel tblLayout_Splitter;
    private System.Windows.Forms.Label lbl_3;
    private System.Windows.Forms.Label lbl_2;
    private System.Windows.Forms.Label lbl_1;
    private System.Windows.Forms.TableLayoutPanel tblLayout_UserPassword;
    private System.Windows.Forms.TextBox tBox_Password;
    private System.Windows.Forms.Label lbl_Password;
    private System.Windows.Forms.TableLayoutPanel tblLayout_LoginButtons;
    private System.Windows.Forms.Button btn_Login;
    private System.Windows.Forms.CheckBox cBox_ShowPassword;
    private System.Windows.Forms.TableLayoutPanel tblLayout_UserID;
    private System.Windows.Forms.TextBox tBox_UserID;
    private System.Windows.Forms.Label lbl_UserID;
    private System.Windows.Forms.TableLayoutPanel tblLayout_Header;
    private System.Windows.Forms.Label lbl_LoginPage;
    private System.Windows.Forms.PictureBox picBox_LoginPageIcon;
    private Button btnIP;
    private TextBox ipBox;
    private Panel panel1;
}