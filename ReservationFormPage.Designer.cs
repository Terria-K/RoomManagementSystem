namespace RoomManagementSystem
{
    partial class ReservationFormPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationFormPage));
            tabPanel = new TabControl();
            requestTab = new TabPage();
            btnView = new Button();
            requestGrid = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            acceptedTab = new TabPage();
            button4 = new Button();
            acceptedGrid = new DataGridView();
            pendingTab = new TabPage();
            button3 = new Button();
            pendingGrid = new DataGridView();
            tabPanel.SuspendLayout();
            requestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestGrid).BeginInit();
            acceptedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)acceptedGrid).BeginInit();
            pendingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pendingGrid).BeginInit();
            SuspendLayout();
            // 
            // tabPanel
            // 
            tabPanel.Controls.Add(requestTab);
            tabPanel.Controls.Add(acceptedTab);
            tabPanel.Controls.Add(pendingTab);
            tabPanel.Location = new Point(14, 16);
            tabPanel.Margin = new Padding(3, 4, 3, 4);
            tabPanel.Name = "tabPanel";
            tabPanel.SelectedIndex = 0;
            tabPanel.Size = new Size(887, 568);
            tabPanel.TabIndex = 0;
            // 
            // requestTab
            // 
            requestTab.BackColor = Color.FromArgb(241, 241, 251);
            requestTab.Controls.Add(btnView);
            requestTab.Controls.Add(requestGrid);
            requestTab.Controls.Add(button2);
            requestTab.Controls.Add(button1);
            requestTab.Location = new Point(4, 29);
            requestTab.Margin = new Padding(3, 4, 3, 4);
            requestTab.Name = "requestTab";
            requestTab.Size = new Size(879, 535);
            requestTab.TabIndex = 2;
            requestTab.Text = "Requests";
            // 
            // btnView
            // 
            btnView.Location = new Point(216, 482);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(145, 40);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += OnViewFromRequests;
            // 
            // requestGrid
            // 
            requestGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestGrid.Location = new Point(3, 4);
            requestGrid.Margin = new Padding(3, 4, 3, 4);
            requestGrid.Name = "requestGrid";
            requestGrid.RowHeadersWidth = 51;
            requestGrid.Size = new Size(871, 460);
            requestGrid.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(518, 482);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(145, 40);
            button2.TabIndex = 2;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnReject;
            // 
            // button1
            // 
            button1.Location = new Point(367, 482);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 1;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnAccept;
            // 
            // acceptedTab
            // 
            acceptedTab.Controls.Add(button4);
            acceptedTab.Controls.Add(acceptedGrid);
            acceptedTab.Location = new Point(4, 29);
            acceptedTab.Margin = new Padding(3, 4, 3, 4);
            acceptedTab.Name = "acceptedTab";
            acceptedTab.Padding = new Padding(3, 4, 3, 4);
            acceptedTab.Size = new Size(879, 535);
            acceptedTab.TabIndex = 0;
            acceptedTab.Text = "Accepted";
            acceptedTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(384, 459);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(110, 48);
            button4.TabIndex = 5;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnViewFromAccepted;
            // 
            // acceptedGrid
            // 
            acceptedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            acceptedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            acceptedGrid.Location = new Point(7, 8);
            acceptedGrid.Margin = new Padding(3, 4, 3, 4);
            acceptedGrid.Name = "acceptedGrid";
            acceptedGrid.ReadOnly = true;
            acceptedGrid.RowHeadersWidth = 51;
            acceptedGrid.Size = new Size(864, 443);
            acceptedGrid.TabIndex = 0;
            // 
            // pendingTab
            // 
            pendingTab.Controls.Add(button3);
            pendingTab.Controls.Add(pendingGrid);
            pendingTab.Location = new Point(4, 29);
            pendingTab.Margin = new Padding(3, 4, 3, 4);
            pendingTab.Name = "pendingTab";
            pendingTab.Padding = new Padding(3, 4, 3, 4);
            pendingTab.Size = new Size(879, 535);
            pendingTab.TabIndex = 1;
            pendingTab.Text = "Pending";
            pendingTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(384, 460);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(110, 48);
            button3.TabIndex = 4;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnViewFromPending;
            // 
            // pendingGrid
            // 
            pendingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingGrid.Location = new Point(7, 8);
            pendingGrid.Margin = new Padding(3, 4, 3, 4);
            pendingGrid.Name = "pendingGrid";
            pendingGrid.ReadOnly = true;
            pendingGrid.RowHeadersWidth = 51;
            pendingGrid.Size = new Size(864, 444);
            pendingGrid.TabIndex = 0;
            // 
            // ReservationFormPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 67);
            ClientSize = new Size(914, 600);
            Controls.Add(tabPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ReservationFormPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Form Page";
            Load += LoadReservationFormPage;
            tabPanel.ResumeLayout(false);
            requestTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestGrid).EndInit();
            acceptedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)acceptedGrid).EndInit();
            pendingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pendingGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPanel;
        private TabPage acceptedTab;
        private TabPage pendingTab;
        private TabPage requestTab;
        private DataGridView requestGrid;
        private DataGridView acceptedGrid;
        private DataGridView pendingGrid;
        private Button btnView;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}