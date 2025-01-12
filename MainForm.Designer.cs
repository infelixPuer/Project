﻿namespace Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pStatusBar = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.lCurrentBalance = new System.Windows.Forms.Label();
            this.lBalance = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bPleasantTasksShop = new System.Windows.Forms.Button();
            this.bPleasantTasks = new System.Windows.Forms.Button();
            this.bTasksTypes = new System.Windows.Forms.Button();
            this.bTasks = new System.Windows.Forms.Button();
            this.pWindows = new System.Windows.Forms.Panel();
            this.lDate = new System.Windows.Forms.Label();
            this.lCurrentDate = new System.Windows.Forms.Label();
            this.pStatusBar.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStatusBar
            // 
            this.pStatusBar.Controls.Add(this.lCurrentDate);
            this.pStatusBar.Controls.Add(this.lDate);
            this.pStatusBar.Controls.Add(this.lName);
            this.pStatusBar.Controls.Add(this.lUserName);
            this.pStatusBar.Controls.Add(this.lCurrentBalance);
            this.pStatusBar.Controls.Add(this.lBalance);
            this.pStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatusBar.Location = new System.Drawing.Point(0, 0);
            this.pStatusBar.Name = "pStatusBar";
            this.pStatusBar.Size = new System.Drawing.Size(800, 45);
            this.pStatusBar.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(222, 18);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(0, 15);
            this.lName.TabIndex = 3;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(150, 18);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(66, 15);
            this.lUserName.TabIndex = 2;
            this.lUserName.Text = "User name:";
            // 
            // lCurrentBalance
            // 
            this.lCurrentBalance.AutoSize = true;
            this.lCurrentBalance.Location = new System.Drawing.Point(69, 18);
            this.lCurrentBalance.Name = "lCurrentBalance";
            this.lCurrentBalance.Size = new System.Drawing.Size(0, 15);
            this.lCurrentBalance.TabIndex = 1;
            // 
            // lBalance
            // 
            this.lBalance.AutoSize = true;
            this.lBalance.Location = new System.Drawing.Point(12, 18);
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(51, 15);
            this.lBalance.TabIndex = 0;
            this.lBalance.Text = "Balance:";
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bPleasantTasksShop);
            this.pButtons.Controls.Add(this.bPleasantTasks);
            this.pButtons.Controls.Add(this.bTasksTypes);
            this.pButtons.Controls.Add(this.bTasks);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pButtons.Location = new System.Drawing.Point(0, 45);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(150, 405);
            this.pButtons.TabIndex = 1;
            // 
            // bPleasantTasksShop
            // 
            this.bPleasantTasksShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bPleasantTasksShop.Location = new System.Drawing.Point(0, 135);
            this.bPleasantTasksShop.Name = "bPleasantTasksShop";
            this.bPleasantTasksShop.Size = new System.Drawing.Size(150, 45);
            this.bPleasantTasksShop.TabIndex = 3;
            this.bPleasantTasksShop.Text = "Pleasant tasks shop";
            this.bPleasantTasksShop.UseVisualStyleBackColor = true;
            this.bPleasantTasksShop.Click += new System.EventHandler(this.bPleasantTasksShop_Click);
            // 
            // bPleasantTasks
            // 
            this.bPleasantTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.bPleasantTasks.Location = new System.Drawing.Point(0, 90);
            this.bPleasantTasks.Name = "bPleasantTasks";
            this.bPleasantTasks.Size = new System.Drawing.Size(150, 45);
            this.bPleasantTasks.TabIndex = 2;
            this.bPleasantTasks.Text = "Pleasant tasks";
            this.bPleasantTasks.UseVisualStyleBackColor = true;
            this.bPleasantTasks.Click += new System.EventHandler(this.bPleasantTasks_Click);
            // 
            // bTasksTypes
            // 
            this.bTasksTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTasksTypes.Location = new System.Drawing.Point(0, 45);
            this.bTasksTypes.Name = "bTasksTypes";
            this.bTasksTypes.Size = new System.Drawing.Size(150, 45);
            this.bTasksTypes.TabIndex = 1;
            this.bTasksTypes.Text = "TasksList types";
            this.bTasksTypes.UseVisualStyleBackColor = true;
            this.bTasksTypes.Click += new System.EventHandler(this.bTasksTypes_Click);
            // 
            // bTasks
            // 
            this.bTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTasks.Location = new System.Drawing.Point(0, 0);
            this.bTasks.Name = "bTasks";
            this.bTasks.Size = new System.Drawing.Size(150, 45);
            this.bTasks.TabIndex = 0;
            this.bTasks.Text = "TasksList";
            this.bTasks.UseVisualStyleBackColor = true;
            this.bTasks.Click += new System.EventHandler(this.bTasks_Click);
            // 
            // pWindows
            // 
            this.pWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWindows.Location = new System.Drawing.Point(150, 45);
            this.pWindows.Name = "pWindows";
            this.pWindows.Size = new System.Drawing.Size(650, 405);
            this.pWindows.TabIndex = 2;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(650, 18);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(34, 15);
            this.lDate.TabIndex = 4;
            this.lDate.Text = "Date:";
            // 
            // lCurrentDate
            // 
            this.lCurrentDate.AutoSize = true;
            this.lCurrentDate.Location = new System.Drawing.Point(690, 18);
            this.lCurrentDate.Name = "lCurrentDate";
            this.lCurrentDate.Size = new System.Drawing.Size(38, 15);
            this.lCurrentDate.TabIndex = 5;
            this.lCurrentDate.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pWindows);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pStatusBar);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.pStatusBar.ResumeLayout(false);
            this.pStatusBar.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pStatusBar;
        private Panel pButtons;
        private Panel pWindows;
        private Button bPleasantTasksShop;
        private Button bPleasantTasks;
        private Button bTasksTypes;
        private Button bTasks;
        public Label lName;
        private Label lUserName;
        public Label lCurrentBalance;
        private Label lBalance;
        private Label lCurrentDate;
        private Label lDate;
    }
}