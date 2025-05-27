namespace RoomManagementSystem
{
    partial class AccountVerificationPage
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
            components = new System.ComponentModel.Container();
            tbluserAccountVerificationBindingSource = new BindingSource(components);
            btn_Approve = new Button();
            btn_Reject = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            unverifiedUserGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tbluserAccountVerificationBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unverifiedUserGrid).BeginInit();
            SuspendLayout();
            // 
            // tbluserAccountVerificationBindingSource
            // 
            tbluserAccountVerificationBindingSource.DataMember = "tbl_userAccountVerification";
            // 
            // btn_Approve
            // 
            btn_Approve.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Approve.Location = new Point(21, 9);
            btn_Approve.Name = "btn_Approve";
            btn_Approve.Size = new Size(149, 32);
            btn_Approve.TabIndex = 1;
            btn_Approve.Text = "Approve";
            btn_Approve.UseVisualStyleBackColor = true;
            btn_Approve.Click += btn_Approve_Click;
            // 
            // btn_Reject
            // 
            btn_Reject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Reject.Location = new Point(200, 9);
            btn_Reject.Name = "btn_Reject";
            btn_Reject.Size = new Size(149, 32);
            btn_Reject.TabIndex = 2;
            btn_Reject.Text = "Reject";
            btn_Reject.UseVisualStyleBackColor = true;
            btn_Reject.Click += btn_Reject_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_Approve, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_Reject, 2, 0);
            tableLayoutPanel1.Location = new Point(274, 417);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(18, 6, 18, 6);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(370, 50);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // unverifiedUserGrid
            // 
            unverifiedUserGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            unverifiedUserGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            unverifiedUserGrid.Location = new Point(12, 12);
            unverifiedUserGrid.Name = "unverifiedUserGrid";
            unverifiedUserGrid.ReadOnly = true;
            unverifiedUserGrid.Size = new Size(895, 408);
            unverifiedUserGrid.TabIndex = 4;
            // 
            // AccountVerificationPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(48, 56, 67);
            ClientSize = new Size(919, 471);
            Controls.Add(unverifiedUserGrid);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AccountVerificationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountVerificationPage";
            Load += AccountVerificationPage_Load;
            ((System.ComponentModel.ISupportInitialize)tbluserAccountVerificationBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)unverifiedUserGrid).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tbluserAccountVerificationBindingSource;
        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private DataGridView unverifiedUserGrid;
    }
}