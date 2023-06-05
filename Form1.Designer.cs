namespace ŞirketOtomasyonu
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
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(53, 97);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 0;
            label1.Text = "Çalışan Adı:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(603, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Maaşı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(603, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(335, 328);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(22, 149);
            label3.Name = "label3";
            label3.Size = new Size(147, 24);
            label3.TabIndex = 5;
            label3.Text = "Çalışan Soyadı:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(603, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
    }
}
