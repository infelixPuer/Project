namespace Project.ChildForms.InputForms
{
    partial class TasksDelete
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
            this.cbTask = new System.Windows.Forms.ComboBox();
            this.lTask = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTask
            // 
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Location = new System.Drawing.Point(12, 27);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(335, 23);
            this.cbTask.TabIndex = 0;
            // 
            // lTask
            // 
            this.lTask.AutoSize = true;
            this.lTask.Location = new System.Drawing.Point(160, 9);
            this.lTask.Name = "lTask";
            this.lTask.Size = new System.Drawing.Size(29, 15);
            this.lTask.TabIndex = 1;
            this.lTask.Text = "Task";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(372, 27);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // TasksDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 61);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lTask);
            this.Controls.Add(this.cbTask);
            this.MaximumSize = new System.Drawing.Size(475, 100);
            this.MinimumSize = new System.Drawing.Size(475, 100);
            this.Name = "TasksDelete";
            this.Text = "TasksDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TasksDelete_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTask;
        private Label lTask;
        private Button bDelete;
    }
}