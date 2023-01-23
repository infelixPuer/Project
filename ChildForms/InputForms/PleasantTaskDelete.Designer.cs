namespace Project.ChildForms.InputForms
{
    partial class PleasantTaskDelete
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
            this.lPleasantTask = new System.Windows.Forms.Label();
            this.cbPleasantTask = new System.Windows.Forms.ComboBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPleasantTask
            // 
            this.lPleasantTask.AutoSize = true;
            this.lPleasantTask.Location = new System.Drawing.Point(127, 9);
            this.lPleasantTask.Name = "lPleasantTask";
            this.lPleasantTask.Size = new System.Drawing.Size(75, 15);
            this.lPleasantTask.TabIndex = 0;
            this.lPleasantTask.Text = "Pleasant task";
            // 
            // cbPleasantTask
            // 
            this.cbPleasantTask.FormattingEnabled = true;
            this.cbPleasantTask.Location = new System.Drawing.Point(12, 27);
            this.cbPleasantTask.Name = "cbPleasantTask";
            this.cbPleasantTask.Size = new System.Drawing.Size(295, 23);
            this.cbPleasantTask.TabIndex = 1;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(325, 27);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // PleasantTaskDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 61);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.cbPleasantTask);
            this.Controls.Add(this.lPleasantTask);
            this.MaximumSize = new System.Drawing.Size(430, 100);
            this.MinimumSize = new System.Drawing.Size(430, 100);
            this.Name = "PleasantTaskDelete";
            this.Text = "PleasantTaskDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PleasantTaskDelete_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lPleasantTask;
        private ComboBox cbPleasantTask;
        private Button bDelete;
    }
}