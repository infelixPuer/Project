﻿namespace Project.ChildForms.InputForms
{
    partial class UserNameInput
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
            this.lUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.bConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(87, 9);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(63, 15);
            this.lUserName.TabIndex = 0;
            this.lUserName.Text = "User name";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(12, 27);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(194, 23);
            this.tbUserName.TabIndex = 1;
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(226, 27);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 23);
            this.bConfirm.TabIndex = 2;
            this.bConfirm.Text = "Confirm";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // UserNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 61);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lUserName);
            this.MaximumSize = new System.Drawing.Size(330, 100);
            this.MinimumSize = new System.Drawing.Size(330, 100);
            this.Name = "UserNameInput";
            this.Text = "UserNameInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lUserName;
        private TextBox tbUserName;
        private Button bConfirm;
    }
}