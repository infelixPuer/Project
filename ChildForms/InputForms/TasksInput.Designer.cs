namespace Project.ChildForms.InputForms
{
    partial class TasksInput
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
            this.lTypeAndCost = new System.Windows.Forms.Label();
            this.lDeadline = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(77, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 15);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // lTypeAndCost
            // 
            this.lTypeAndCost.AutoSize = true;
            this.lTypeAndCost.Location = new System.Drawing.Point(255, 9);
            this.lTypeAndCost.Name = "lTypeAndCost";
            this.lTypeAndCost.Size = new System.Drawing.Size(79, 15);
            this.lTypeAndCost.TabIndex = 1;
            this.lTypeAndCost.Text = "Type and cost";
            // 
            // lDeadline
            // 
            this.lDeadline.AutoSize = true;
            this.lDeadline.Location = new System.Drawing.Point(473, 9);
            this.lDeadline.Name = "lDeadline";
            this.lDeadline.Size = new System.Drawing.Size(53, 15);
            this.lDeadline.TabIndex = 2;
            this.lDeadline.Text = "Deadline";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 23);
            this.tbName.TabIndex = 3;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(407, 27);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(200, 23);
            this.dtpDeadline.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(223, 27);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(154, 23);
            this.cbType.TabIndex = 5;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(632, 27);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // TasksInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 61);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lDeadline);
            this.Controls.Add(this.lTypeAndCost);
            this.Controls.Add(this.lName);
            this.MaximumSize = new System.Drawing.Size(735, 100);
            this.MinimumSize = new System.Drawing.Size(735, 100);
            this.Name = "TasksInput";
            this.Text = "TasksInput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TasksInput_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lName;
        private Label lTypeAndCost;
        private Label lDeadline;
        private TextBox tbName;
        private DateTimePicker dtpDeadline;
        private ComboBox cbType;
        private Button bAdd;
    }
}