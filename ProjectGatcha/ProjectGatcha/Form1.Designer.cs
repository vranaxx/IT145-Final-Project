namespace ProjectGatcha
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
            Gamble1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            Gamble2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            Gamble3 = new Button();
            CurrencyLabel = new Label();
            SuspendLayout();
            // 
            // Gamble1
            // 
            Gamble1.Location = new Point(68, 205);
            Gamble1.Name = "Gamble1";
            Gamble1.Size = new Size(94, 29);
            Gamble1.TabIndex = 0;
            Gamble1.Text = "Gamble";
            Gamble1.UseVisualStyleBackColor = true;
            Gamble1.Click += Gamble1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 79);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingredient1";
            // 
            // Gamble2
            // 
            Gamble2.Location = new Point(255, 205);
            Gamble2.Name = "Gamble2";
            Gamble2.Size = new Size(94, 29);
            Gamble2.TabIndex = 3;
            Gamble2.Text = "Gamble";
            Gamble2.UseVisualStyleBackColor = true;
            Gamble2.Click += Gamble2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 79);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingredient2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 79);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 6;
            label3.Text = "Ingredient3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(439, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // Gamble3
            // 
            Gamble3.Location = new Point(452, 205);
            Gamble3.Name = "Gamble3";
            Gamble3.Size = new Size(94, 29);
            Gamble3.TabIndex = 8;
            Gamble3.Text = "Gamble";
            Gamble3.UseVisualStyleBackColor = true;
            Gamble3.Click += Gamble3_Click;
            // 
            // CurrencyLabel
            // 
            CurrencyLabel.AutoSize = true;
            CurrencyLabel.Location = new Point(274, 319);
            CurrencyLabel.Name = "CurrencyLabel";
            CurrencyLabel.Size = new Size(84, 20);
            CurrencyLabel.TabIndex = 9;
            CurrencyLabel.Text = "Food Coin: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrencyLabel);
            Controls.Add(Gamble3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(Gamble2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Gamble1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Gamble1;
        private TextBox textBox1;
        private Label label1;
        private Button Gamble2;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button Gamble3;
        private Label CurrencyLabel;
    }
}
