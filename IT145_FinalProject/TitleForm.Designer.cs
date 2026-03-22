namespace IT145_FinalProject
{
    partial class TitleForm
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
            createcharButton = new Button();
            charnameTxt = new TextBox();
            displayprofstatButton = new Button();
            professionCombo = new ComboBox();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // createcharButton
            // 
            createcharButton.Location = new Point(51, 389);
            createcharButton.Name = "createcharButton";
            createcharButton.Size = new Size(150, 33);
            createcharButton.TabIndex = 0;
            createcharButton.Text = "Create Character";
            createcharButton.UseVisualStyleBackColor = true;
            createcharButton.Click += createcharButton_Click;
            // 
            // charnameTxt
            // 
            charnameTxt.Location = new Point(51, 322);
            charnameTxt.Name = "charnameTxt";
            charnameTxt.Size = new Size(150, 27);
            charnameTxt.TabIndex = 2;
            // 
            // displayprofstatButton
            // 
            displayprofstatButton.Location = new Point(34, 43);
            displayprofstatButton.Name = "displayprofstatButton";
            displayprofstatButton.Size = new Size(94, 29);
            displayprofstatButton.TabIndex = 3;
            displayprofstatButton.Text = "Stat";
            displayprofstatButton.UseVisualStyleBackColor = true;
            displayprofstatButton.Click += displayprofstatButton_Click;
            // 
            // professionCombo
            // 
            professionCombo.FormattingEnabled = true;
            professionCombo.Items.AddRange(new object[] { "Warrior", "Tank", "Ranged" });
            professionCombo.Location = new Point(51, 355);
            professionCombo.Name = "professionCombo";
            professionCombo.Size = new Size(151, 28);
            professionCombo.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(208, 329);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // TitleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nameLabel);
            Controls.Add(professionCombo);
            Controls.Add(displayprofstatButton);
            Controls.Add(charnameTxt);
            Controls.Add(createcharButton);
            Name = "TitleForm";
            Text = "TitleForm";
            Load += TitleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createcharButton;
        private TextBox charnameTxt;
        private Button displayprofstatButton;
        private ComboBox professionCombo;
        private Label nameLabel;
    }
}