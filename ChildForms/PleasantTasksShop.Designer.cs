namespace Project.ChildForms
{
    partial class PleasantTasksShop
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
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(692, 393);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(45, 45);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Location = new System.Drawing.Point(743, 393);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(45, 45);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "-";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // PleasantTasksShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Name = "PleasantTasksShop";
            this.Text = "PleasantTasksShop";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bAdd;
        private Button bDelete;
    }
}