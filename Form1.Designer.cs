namespace money_convertor
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
            label2 = new Label();
            txt1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(189, 47);
            label1.Name = "label1";
            label1.Size = new Size(225, 30);
            label1.TabIndex = 0;
            label1.Text = "MONEY CONVERTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 126);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter  Amount (LKR)";
            label2.Click += label2_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(204, 123);
            txt1.Name = "txt1";
            txt1.Size = new Size(210, 23);
            txt1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 229);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "USD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 229);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 4;
            label4.Text = "AED";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 229);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 5;
            label5.Text = "PKR";
            // 
            // txt2
            // 
            txt2.Location = new Point(84, 226);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 6;
            // 
            // txt3
            // 
            txt3.Location = new Point(251, 226);
            txt3.Name = "txt3";
            txt3.Size = new Size(100, 23);
            txt3.TabIndex = 7;
            // 
            // txt4
            // 
            txt4.Location = new Point(430, 226);
            txt4.Name = "txt4";
            txt4.Size = new Size(100, 23);
            txt4.TabIndex = 8;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(176, 337);
            button1.Name = "button1";
            button1.Size = new Size(255, 44);
            button1.TabIndex = 9;
            button1.Text = "CONVERT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(606, 450);
            Controls.Add(button1);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private Button button1;
    }
}