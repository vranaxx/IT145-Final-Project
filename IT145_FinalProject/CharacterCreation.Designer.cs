namespace IT145_FinalProject
{
    partial class CharacterCreation
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
            displayprofstatButton = new Button();
            createcharButton = new Button();
            professionCombo = new ComboBox();
            charnameTxt = new TextBox();
            nameLabel = new Label();
            TopBarPanel = new Panel();
            ExitButton = new Button();
            CharCreateMenuPanel = new Panel();
            characterCombo = new ComboBox();
            BackButton = new Button();
            TopBarPanel.SuspendLayout();
            CharCreateMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // displayprofstatButton
            // 
            displayprofstatButton.Location = new Point(31, 135);
            displayprofstatButton.Name = "displayprofstatButton";
            displayprofstatButton.Size = new Size(94, 29);
            displayprofstatButton.TabIndex = 4;
            displayprofstatButton.Text = "Stat";
            displayprofstatButton.UseVisualStyleBackColor = true;
            displayprofstatButton.Click += displayprofstatButton_Click;
            // 
            // createcharButton
            // 
            createcharButton.Location = new Point(31, 96);
            createcharButton.Name = "createcharButton";
            createcharButton.Size = new Size(150, 33);
            createcharButton.TabIndex = 5;
            createcharButton.Text = "Create Character";
            createcharButton.UseVisualStyleBackColor = true;
            createcharButton.Click += createcharButton_Click;
            // 
            // professionCombo
            // 
            professionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            professionCombo.FormattingEnabled = true;
            professionCombo.Items.AddRange(new object[] { "Warrior", "Tank", "Ranged" });
            professionCombo.Location = new Point(31, 62);
            professionCombo.Name = "professionCombo";
            professionCombo.Size = new Size(151, 28);
            professionCombo.TabIndex = 6;
            // 
            // charnameTxt
            // 
            charnameTxt.Location = new Point(31, 29);
            charnameTxt.Name = "charnameTxt";
            charnameTxt.Size = new Size(150, 27);
            charnameTxt.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(31, 6);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = SystemColors.ControlDarkDark;
            TopBarPanel.Controls.Add(ExitButton);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(800, 25);
            TopBarPanel.TabIndex = 11;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.BackgroundImage = Properties.Resources.ExitX;
            ExitButton.Location = new Point(777, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(20, 20);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // CharCreateMenuPanel
            // 
            CharCreateMenuPanel.BackgroundImage = Properties.Resources.paper_background;
            CharCreateMenuPanel.Controls.Add(characterCombo);
            CharCreateMenuPanel.Controls.Add(BackButton);
            CharCreateMenuPanel.Controls.Add(charnameTxt);
            CharCreateMenuPanel.Controls.Add(professionCombo);
            CharCreateMenuPanel.Controls.Add(nameLabel);
            CharCreateMenuPanel.Controls.Add(displayprofstatButton);
            CharCreateMenuPanel.Controls.Add(createcharButton);
            CharCreateMenuPanel.Dock = DockStyle.Left;
            CharCreateMenuPanel.Location = new Point(0, 25);
            CharCreateMenuPanel.Name = "CharCreateMenuPanel";
            CharCreateMenuPanel.Size = new Size(200, 450);
            CharCreateMenuPanel.TabIndex = 12;
            // 
            // characterCombo
            // 
            characterCombo.DisplayMember = "GetCharacterName";
            characterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            characterCombo.FormattingEnabled = true;
            characterCombo.Items.AddRange(new object[] { "Warrior", "Tank", "Ranged" });
            characterCombo.Location = new Point(30, 170);
            characterCombo.Name = "characterCombo";
            characterCombo.Size = new Size(151, 28);
            characterCombo.TabIndex = 10;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            BackButton.BackgroundImageLayout = ImageLayout.Stretch;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.Cyan;
            BackButton.Location = new Point(11, 393);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(170, 45);
            BackButton.TabIndex = 9;
            BackButton.Text = "Characters";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(CharCreateMenuPanel);
            Controls.Add(TopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CharacterCreation";
            Text = "CharacterCreation";
            Load += CharacterCreation_Load;
            TopBarPanel.ResumeLayout(false);
            CharCreateMenuPanel.ResumeLayout(false);
            CharCreateMenuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button displayprofstatButton;
        private Button createcharButton;
        private ComboBox professionCombo;
        private TextBox charnameTxt;
        private Label nameLabel;
        private Panel TopBarPanel;
        private Button ExitButton;
        private Panel CharCreateMenuPanel;
        private Button BackButton;
        private ComboBox characterCombo;
    }
}