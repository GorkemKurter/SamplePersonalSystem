namespace PersonalSystem
{
    partial class Form2
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
            this.txt2Name = new System.Windows.Forms.TextBox();
            this.txt2Surname = new System.Windows.Forms.TextBox();
            this.txt2City = new System.Windows.Forms.TextBox();
            this.txt2Salary = new System.Windows.Forms.TextBox();
            this.txt2Job = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb2Single = new System.Windows.Forms.RadioButton();
            this.rdb2Married = new System.Windows.Forms.RadioButton();
            this.btnf2Update = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt2Name
            // 
            this.txt2Name.Location = new System.Drawing.Point(388, 47);
            this.txt2Name.Name = "txt2Name";
            this.txt2Name.Size = new System.Drawing.Size(123, 36);
            this.txt2Name.TabIndex = 0;
            // 
            // txt2Surname
            // 
            this.txt2Surname.Location = new System.Drawing.Point(388, 103);
            this.txt2Surname.Name = "txt2Surname";
            this.txt2Surname.Size = new System.Drawing.Size(123, 36);
            this.txt2Surname.TabIndex = 1;
            // 
            // txt2City
            // 
            this.txt2City.Location = new System.Drawing.Point(388, 161);
            this.txt2City.Name = "txt2City";
            this.txt2City.Size = new System.Drawing.Size(123, 36);
            this.txt2City.TabIndex = 2;
            // 
            // txt2Salary
            // 
            this.txt2Salary.Location = new System.Drawing.Point(388, 228);
            this.txt2Salary.Name = "txt2Salary";
            this.txt2Salary.Size = new System.Drawing.Size(123, 36);
            this.txt2Salary.TabIndex = 3;
            // 
            // txt2Job
            // 
            this.txt2Job.Location = new System.Drawing.Point(388, 358);
            this.txt2Job.Name = "txt2Job";
            this.txt2Job.Size = new System.Drawing.Size(123, 36);
            this.txt2Job.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Job:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status:";
            // 
            // rdb2Single
            // 
            this.rdb2Single.AutoSize = true;
            this.rdb2Single.Location = new System.Drawing.Point(501, 296);
            this.rdb2Single.Name = "rdb2Single";
            this.rdb2Single.Size = new System.Drawing.Size(91, 32);
            this.rdb2Single.TabIndex = 22;
            this.rdb2Single.TabStop = true;
            this.rdb2Single.Text = "Single";
            this.rdb2Single.UseVisualStyleBackColor = true;
            this.rdb2Single.CheckedChanged += new System.EventHandler(this.rdb2Single_CheckedChanged);
            // 
            // rdb2Married
            // 
            this.rdb2Married.AutoSize = true;
            this.rdb2Married.Location = new System.Drawing.Point(388, 298);
            this.rdb2Married.Name = "rdb2Married";
            this.rdb2Married.Size = new System.Drawing.Size(107, 32);
            this.rdb2Married.TabIndex = 21;
            this.rdb2Married.TabStop = true;
            this.rdb2Married.Text = "Married";
            this.rdb2Married.UseVisualStyleBackColor = true;
            this.rdb2Married.CheckedChanged += new System.EventHandler(this.rdb2Married_CheckedChanged);
            // 
            // btnf2Update
            // 
            this.btnf2Update.Location = new System.Drawing.Point(397, 433);
            this.btnf2Update.Name = "btnf2Update";
            this.btnf2Update.Size = new System.Drawing.Size(114, 41);
            this.btnf2Update.TabIndex = 23;
            this.btnf2Update.Text = "Update";
            this.btnf2Update.UseVisualStyleBackColor = true;
            this.btnf2Update.Click += new System.EventHandler(this.btnf2Update_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(96, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 38);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(685, 543);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnf2Update);
            this.Controls.Add(this.rdb2Single);
            this.Controls.Add(this.rdb2Married);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2Job);
            this.Controls.Add(this.txt2Salary);
            this.Controls.Add(this.txt2City);
            this.Controls.Add(this.txt2Surname);
            this.Controls.Add(this.txt2Name);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt2Name;
        private System.Windows.Forms.TextBox txt2Surname;
        private System.Windows.Forms.TextBox txt2City;
        private System.Windows.Forms.TextBox txt2Salary;
        private System.Windows.Forms.TextBox txt2Job;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb2Single;
        private System.Windows.Forms.RadioButton rdb2Married;
        private System.Windows.Forms.Button btnf2Update;
        private System.Windows.Forms.Button btnBack;
    }
}