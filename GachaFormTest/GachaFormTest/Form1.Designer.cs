namespace GachaFormTest
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
            lstIngredients = new ListBox();
            btnPull = new Button();
            lblResult = new Label();
            label1 = new Label();
            lblCurrency = new Label();
            SuspendLayout();
            // 
            // lstIngredients
            // 
            lstIngredients.FormattingEnabled = true;
            lstIngredients.Location = new Point(210, 72);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(261, 164);
            lstIngredients.TabIndex = 0;
            lstIngredients.SelectedIndexChanged += lstIngredients_SelectedIndexChanged;
            // 
            // btnPull
            // 
            btnPull.Location = new Point(509, 124);
            btnPull.Name = "btnPull";
            btnPull.Size = new Size(147, 70);
            btnPull.TabIndex = 1;
            btnPull.Text = "Gamble";
            btnPull.UseVisualStyleBackColor = true;
            btnPull.Click += btnPull_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(540, 263);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(64, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "You Got:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 23);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 3;
            label1.Text = "Possible Ingredents:";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(502, 72);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(154, 20);
            lblCurrency.TabIndex = 4;
            lblCurrency.Text = "Your Current Currency:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrency);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnPull);
            Controls.Add(lstIngredients);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstIngredients;
        private Button btnPull;
        private Label lblResult;
        private Label label1;
        private Label lblCurrency;
    }
}
