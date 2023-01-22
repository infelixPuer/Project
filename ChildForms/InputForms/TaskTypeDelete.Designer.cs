namespace Project.ChildForms.InputForms
{
    partial class TaskTypeDelete
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 27);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(201, 23);
            this.cbType.TabIndex = 0;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(90, 9);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(31, 15);
            this.lType.TabIndex = 1;
            this.lType.Text = "Type";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(238, 27);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // TaskTypeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 66);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.cbType);
            this.MaximumSize = new System.Drawing.Size(340, 105);
            this.MinimumSize = new System.Drawing.Size(340, 105);
            this.Name = "TaskTypeDelete";
            this.Text = "TaskTypeDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskTypeDelete_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbType;
        private Label lType;
        private Button bDelete;
    }
}