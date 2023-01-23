namespace Project.ChildForms.InputForms
{
    partial class PleasantTaskInput
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
            this.lName = new System.Windows.Forms.Label();
            this.lCost = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(138, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 15);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(365, 9);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(31, 15);
            this.lCost.TabIndex = 1;
            this.lCost.Text = "Cost";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(308, 23);
            this.tbName.TabIndex = 2;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(344, 27);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(78, 23);
            this.tbCost.TabIndex = 3;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(443, 27);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // PleasantTaskInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 61);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.lName);
            this.MaximumSize = new System.Drawing.Size(545, 100);
            this.MinimumSize = new System.Drawing.Size(545, 100);
            this.Name = "PleasantTaskInput";
            this.Text = "PleasantTaskInput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PleasantTaskInput_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lName;
        private Label lCost;
        private TextBox tbName;
        private TextBox tbCost;
        private Button bAdd;
    }
}