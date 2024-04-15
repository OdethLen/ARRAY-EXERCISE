namespace ARRAY_EXERCISE
{
    partial class Form1
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
            label1 = new Label();
            txtName = new TextBox();
            btnSaveName = new Button();
            label2 = new Label();
            txtGrades = new TextBox();
            btnSaveGrades = new Button();
            txtCareer = new TextBox();
            btnSaveCareer = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnSaveName
            // 
            btnSaveName.Location = new Point(208, 44);
            btnSaveName.Name = "btnSaveName";
            btnSaveName.Size = new Size(89, 23);
            btnSaveName.TabIndex = 2;
            btnSaveName.Text = "Save Name";
            btnSaveName.UseVisualStyleBackColor = true;
            btnSaveName.Click += btnSaveName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Grades:";
            // 
            // txtGrades
            // 
            txtGrades.Location = new Point(75, 77);
            txtGrades.Name = "txtGrades";
            txtGrades.Size = new Size(100, 23);
            txtGrades.TabIndex = 4;
            // 
            // btnSaveGrades
            // 
            btnSaveGrades.Location = new Point(208, 81);
            btnSaveGrades.Name = "btnSaveGrades";
            btnSaveGrades.Size = new Size(89, 23);
            btnSaveGrades.TabIndex = 5;
            btnSaveGrades.Text = "Save Grades";
            btnSaveGrades.UseVisualStyleBackColor = true;
            btnSaveGrades.Click += btnSaveGrades_Click;
            // 
            // txtCareer
            // 
            txtCareer.Location = new Point(75, 116);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new Size(100, 23);
            txtCareer.TabIndex = 6;
            // 
            // btnSaveCareer
            // 
            btnSaveCareer.Location = new Point(208, 115);
            btnSaveCareer.Name = "btnSaveCareer";
            btnSaveCareer.Size = new Size(89, 23);
            btnSaveCareer.TabIndex = 7;
            btnSaveCareer.Text = "Save Career";
            btnSaveCareer.UseVisualStyleBackColor = true;
            btnSaveCareer.Click += btnSaveCareer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 124);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Career:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 209);
            Controls.Add(label3);
            Controls.Add(btnSaveCareer);
            Controls.Add(txtCareer);
            Controls.Add(btnSaveGrades);
            Controls.Add(txtGrades);
            Controls.Add(label2);
            Controls.Add(btnSaveName);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnSaveName;
        private Label label2;
        private TextBox txtGrades;
        private Button btnSaveGrades;
        private TextBox txtCareer;
        private Button btnSaveCareer;
        private Label label3;
    }
}
