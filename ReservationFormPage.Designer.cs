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
            tabPanel.Location = new Point(12, 12);
            tabPanel.Name = "tabPanel";
            tabPanel.SelectedIndex = 0;
            tabPanel.Size = new Size(776, 426);
            tabPanel.TabIndex = 0;
            // 
            // requestTab
            // 
            requestTab.Controls.Add(btnView);
            requestTab.Controls.Add(requestGrid);
            requestTab.Controls.Add(button2);
            requestTab.Controls.Add(button1);
            requestTab.Location = new Point(4, 24);
            requestTab.Name = "requestTab";
            requestTab.Size = new Size(768, 398);
            requestTab.TabIndex = 2;
            requestTab.Text = "Requests";
            requestTab.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(239, 354);
            btnView.Name = "btnView";
            btnView.Size = new Size(96, 36);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += OnViewFromRequests;
            // 
            // requestGrid
            // 
            requestGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestGrid.Location = new Point(3, 3);
            requestGrid.Name = "requestGrid";
            requestGrid.Size = new Size(762, 345);
            requestGrid.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(443, 354);
            button2.Name = "button2";
            button2.Size = new Size(86, 36);
            button2.TabIndex = 2;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnReject;
            // 
            // button1
            // 
            button1.Location = new Point(341, 354);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 1;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnAccept;
            // 
            // acceptedTab
            // 
            acceptedTab.Controls.Add(button4);
            acceptedTab.Controls.Add(acceptedGrid);
            acceptedTab.Location = new Point(4, 24);
            acceptedTab.Name = "acceptedTab";
            acceptedTab.Padding = new Padding(3);
            acceptedTab.Size = new Size(768, 398);
            acceptedTab.TabIndex = 0;
            acceptedTab.Text = "Accepted";
            acceptedTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(336, 344);
            button4.Name = "button4";
            button4.Size = new Size(96, 36);
            button4.TabIndex = 5;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnViewFromAccepted;
            // 
            // acceptedGrid
            // 
            acceptedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            acceptedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            acceptedGrid.Location = new Point(6, 6);
            acceptedGrid.Name = "acceptedGrid";
            acceptedGrid.ReadOnly = true;
            acceptedGrid.Size = new Size(756, 332);
            acceptedGrid.TabIndex = 0;
            // 
            // pendingTab
            // 
            pendingTab.Controls.Add(button3);
            pendingTab.Controls.Add(pendingGrid);
            pendingTab.Location = new Point(4, 24);
            pendingTab.Name = "pendingTab";
            pendingTab.Padding = new Padding(3);
            pendingTab.Size = new Size(768, 398);
            pendingTab.TabIndex = 1;
            pendingTab.Text = "Pending";
            pendingTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(336, 345);
            button3.Name = "button3";
            button3.Size = new Size(96, 36);
            button3.TabIndex = 4;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnViewFromPending;
            // 
            // pendingGrid
            // 
            pendingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingGrid.Location = new Point(6, 6);
            pendingGrid.Name = "pendingGrid";
            pendingGrid.ReadOnly = true;
            pendingGrid.Size = new Size(756, 333);
            pendingGrid.TabIndex = 0;
            // 
            // ReservationFormPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabPanel);
            Name = "ReservationFormPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservationFormPage";
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