namespace IT145_FinalProject
{
    partial class SubForm
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
            Back = new Button();
            ShowText = new Label();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(376, 363);
            Back.Name = "Back";
            Back.Size = new Size(94, 29);
            Back.TabIndex = 0;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // ShowText
            // 
            ShowText.AutoSize = true;
            ShowText.Location = new Point(344, 215);
            ShowText.Name = "ShowText";
            ShowText.Size = new Size(88, 20);
            ShowText.TabIndex = 1;
            ShowText.Text = "placeholder";
            // 
            // SubForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowText);
            Controls.Add(Back);
            Name = "SubForm";
            Text = "Form2";
            FormClosing += CloseMainForm;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label ShowText;
    }
}