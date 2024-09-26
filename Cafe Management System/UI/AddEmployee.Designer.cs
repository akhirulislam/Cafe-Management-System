namespace Cafe_Management_System.UI
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label8 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(174, 2);
            label7.Name = "label7";
            label7.Size = new Size(452, 75);
            label7.TabIndex = 34;
            label7.Text = "ADD EMPLOYEE";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Consolas", 14.25F, FontStyle.Bold);
            textBox3.Location = new Point(296, 378);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 31);
            textBox3.TabIndex = 33;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            label6.Location = new Point(160, 378);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 30;
            label6.Text = "Post :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            label5.Location = new Point(159, 332);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 29;
            label5.Text = "Salary : ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.GradientActiveCaption;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(577, 233);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 23);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.GradientActiveCaption;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(474, 233);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 23);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 235);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 26;
            label4.Text = "Gender : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            label3.Location = new Point(160, 231);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 25;
            label3.Text = "Age :";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormatString = "N0";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" });
            comboBox2.Location = new Point(284, 231);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(53, 23);
            comboBox2.TabIndex = 24;
            comboBox2.Text = "16";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            label2.Location = new Point(159, 278);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 23;
            label2.Text = "Joining Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 131);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 22;
            label1.Text = "Name : ";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Consolas", 14.25F, FontStyle.Bold);
            textBox2.Location = new Point(296, 332);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 31);
            textBox2.TabIndex = 21;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(333, 116);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 39);
            textBox1.TabIndex = 20;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(577, 327);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 19;
            button1.Text = "Add Employee ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Consolas", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(343, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 30);
            dateTimePicker1.TabIndex = 35;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(577, 375);
            button2.Name = "button2";
            button2.Size = new Size(152, 34);
            button2.TabIndex = 36;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Info;
            label8.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(160, 176);
            label8.Name = "label8";
            label8.Size = new Size(154, 24);
            label8.TabIndex = 52;
            label8.Text = "Employee ID:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Consolas", 14.25F, FontStyle.Bold);
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(333, 161);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 39);
            textBox4.TabIndex = 53;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label8;
        private TextBox textBox4;
    }
}