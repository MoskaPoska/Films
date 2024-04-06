namespace Films
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 46);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Название фильма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 110);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 3;
            label2.Text = "Год";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Movie" });
            comboBox1.Location = new Point(57, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 23);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(56, 234);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 5;
            button1.Text = "Скачать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 46);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(494, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 190);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(494, 303);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 135);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox3;
    }
}