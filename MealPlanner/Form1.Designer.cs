namespace MealPlan
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Meat = new DataGridViewTextBoxColumn();
            Cereal = new DataGridViewTextBoxColumn();
            Vegetable = new DataGridViewTextBoxColumn();
            Dairy = new DataGridViewTextBoxColumn();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter your budget:";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 1;
            textBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(695, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Generate ";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Meat, Cereal, Vegetable, Dairy });
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(783, 309);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Meat
            // 
            Meat.HeaderText = "Meat";
            Meat.Name = "Meat";
            Meat.Width = 185;
            // 
            // Cereal
            // 
            Cereal.HeaderText = "Cereal";
            Cereal.Name = "Cereal";
            Cereal.Width = 185;
            // 
            // Vegetable
            // 
            Vegetable.HeaderText = "Vegetable";
            Vegetable.Name = "Vegetable";
            Vegetable.Width = 185;
            // 
            // Dairy
            // 
            Dairy.HeaderText = "Dairy";
            Dairy.Name = "Dairy";
            Dairy.Width = 185;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(574, 416);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 16);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(474, 411);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 5;
            label2.Text = "Total price:";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 215);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 6;
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 409);
            label4.Name = "label4";
            label4.Size = new Size(200, 21);
            label4.TabIndex = 7;
            label4.Text = "Total calories per person:";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Location = new Point(288, 414);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 16);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(515, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 9;
            textBox2.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(369, 31);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 10;
            label5.Text = "Number of people:";
            label5.UseWaitCursor = true;
            label5.Click += label5_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(156, 13);
            label6.Name = "label6";
            label6.Size = new Size(155, 13);
            label6.TabIndex = 11;
            label6.Text = "Note: minimal per person 2$";
            label6.UseWaitCursor = true;
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MealPlaner";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private DataGridViewTextBoxColumn Meat;
        private DataGridViewTextBoxColumn Cereal;
        private DataGridViewTextBoxColumn Vegetable;
        private DataGridViewTextBoxColumn Dairy;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
    }
}
