namespace Project.ChildForms
{
    partial class PleasantTasks
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
            this.bCompleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCompleted
            // 
            this.bCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCompleted.Location = new System.Drawing.Point(713, 415);
            this.bCompleted.Name = "bCompleted";
            this.bCompleted.Size = new System.Drawing.Size(75, 23);
            this.bCompleted.TabIndex = 0;
            this.bCompleted.Text = "Completed";
            this.bCompleted.UseVisualStyleBackColor = true;
            this.bCompleted.Click += new System.EventHandler(this.bCompleted_Click);
            // 
            // PleasantTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCompleted);
            this.Name = "PleasantTasks";
            this.Text = "PleasantTasks";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bCompleted;
    }
}