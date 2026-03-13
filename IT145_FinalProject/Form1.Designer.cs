namespace IT145_FinalProject
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
            RPG = new Button();
            Gacha = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // RPG
            // 
            RPG.Location = new Point(218, 277);
            RPG.Name = "RPG";
            RPG.Size = new Size(94, 29);
            RPG.TabIndex = 0;
            RPG.Text = "RPG";
            RPG.UseVisualStyleBackColor = true;
            RPG.Click += Form_Click;
            // 
            // Gacha
            // 
            Gacha.Location = new Point(318, 277);
            Gacha.Name = "Gacha";
            Gacha.Size = new Size(94, 29);
            Gacha.TabIndex = 1;
            Gacha.Text = "Gacha";
            Gacha.UseVisualStyleBackColor = true;
            Gacha.Click += Form_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 254);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 2;
            label1.Text = "Click to open subform";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Gacha);
            Controls.Add(RPG);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RPG;
        private Button Gacha;
        private Label label1;
    }
}
