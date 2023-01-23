namespace Project.ChildForms
{
    partial class Tasks
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAdd.Location = new System.Drawing.Point(466, 331);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Location = new System.Drawing.Point(547, 331);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bComplete
            // 
            this.bComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bComplete.Location = new System.Drawing.Point(385, 331);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(75, 23);
            this.bComplete.TabIndex = 2;
            this.bComplete.Text = "Complete";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.bComplete);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.MaximumSize = new System.Drawing.Size(650, 405);
            this.MinimumSize = new System.Drawing.Size(650, 405);
            this.Name = "Tasks";
            this.Text = "TasksList";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bAdd;
        private Button bDelete;
        private Button bComplete;
    }
}