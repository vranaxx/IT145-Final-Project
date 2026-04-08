namespace IT145_FinalProject
{
    partial class CombatForm
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
            TopBarPanel = new Panel();
            ExitButton = new Button();
            GameMainMenuPanel = new Panel();
            CharactersButton = new Button();
            AbbilitiesButton = new Button();
            BackButton = new Button();
            GameMainViewPanel = new Panel();
            TurnTrackerLabel = new Label();
            Enemy3HealthBox = new TextBox();
            Enemy2HealthBox = new TextBox();
            Enemy1HealthBox = new TextBox();
            Ally1HealthBox = new TextBox();
            Ally2HealthBox = new TextBox();
            Enemy3IntBox = new TextBox();
            Enemy2IntBox = new TextBox();
            Enemy1IntBox = new TextBox();
            Ally1IntBox = new TextBox();
            Ally2IntBox = new TextBox();
            Enemy3AtkBox = new TextBox();
            Enemy2AtkBox = new TextBox();
            Enemy1AtkBox = new TextBox();
            Ally1AtkBox = new TextBox();
            Ally2AtkBox = new TextBox();
            Ally3IntBox = new TextBox();
            Ally3AtkBox = new TextBox();
            Ally3HealthBox = new TextBox();
            Enemy3Panel = new Panel();
            Enemy2Panel = new Panel();
            Ally3Panel = new Panel();
            Ally2Panel = new Panel();
            CombatAbilityPanel = new Panel();
            AbilityHideButton = new Button();
            Ability4Button = new Button();
            Ability3Button = new Button();
            Ability2Button = new Button();
            Ability1Button = new Button();
            Enemy1Panel = new Panel();
            Ally1Panel = new Panel();
            Enemy1Indicator = new Button();
            Enemy2Indicator = new Button();
            Enemy3Indicator = new Button();
            TopBarPanel.SuspendLayout();
            GameMainMenuPanel.SuspendLayout();
            GameMainViewPanel.SuspendLayout();
            CombatAbilityPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = SystemColors.ControlDarkDark;
            TopBarPanel.Controls.Add(ExitButton);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(800, 25);
            TopBarPanel.TabIndex = 12;
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
            // GameMainMenuPanel
            // 
            GameMainMenuPanel.BackgroundImage = Properties.Resources.paper_background;
            GameMainMenuPanel.Controls.Add(CharactersButton);
            GameMainMenuPanel.Controls.Add(AbbilitiesButton);
            GameMainMenuPanel.Controls.Add(BackButton);
            GameMainMenuPanel.Dock = DockStyle.Left;
            GameMainMenuPanel.Location = new Point(0, 25);
            GameMainMenuPanel.Name = "GameMainMenuPanel";
            GameMainMenuPanel.Size = new Size(200, 450);
            GameMainMenuPanel.TabIndex = 14;
            // 
            // CharactersButton
            // 
            CharactersButton.BackColor = Color.Transparent;
            CharactersButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            CharactersButton.BackgroundImageLayout = ImageLayout.Stretch;
            CharactersButton.FlatAppearance.BorderSize = 0;
            CharactersButton.FlatStyle = FlatStyle.Flat;
            CharactersButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CharactersButton.ForeColor = Color.Cyan;
            CharactersButton.Location = new Point(12, 57);
            CharactersButton.Name = "CharactersButton";
            CharactersButton.Size = new Size(170, 45);
            CharactersButton.TabIndex = 6;
            CharactersButton.Text = "Characters";
            CharactersButton.UseVisualStyleBackColor = false;
            // 
            // AbbilitiesButton
            // 
            AbbilitiesButton.BackColor = Color.Transparent;
            AbbilitiesButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            AbbilitiesButton.BackgroundImageLayout = ImageLayout.Stretch;
            AbbilitiesButton.FlatAppearance.BorderSize = 0;
            AbbilitiesButton.FlatStyle = FlatStyle.Flat;
            AbbilitiesButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AbbilitiesButton.ForeColor = Color.Cyan;
            AbbilitiesButton.Location = new Point(12, 6);
            AbbilitiesButton.Name = "AbbilitiesButton";
            AbbilitiesButton.Size = new Size(170, 45);
            AbbilitiesButton.TabIndex = 5;
            AbbilitiesButton.Text = "Abilities";
            AbbilitiesButton.UseVisualStyleBackColor = false;
            AbbilitiesButton.Click += VentureButton_Click;
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
            BackButton.Location = new Point(12, 393);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(170, 45);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // GameMainViewPanel
            // 
            GameMainViewPanel.BackgroundImage = Properties.Resources.Battlebackkground1;
            GameMainViewPanel.Controls.Add(Enemy3Indicator);
            GameMainViewPanel.Controls.Add(Enemy2Indicator);
            GameMainViewPanel.Controls.Add(Enemy1Indicator);
            GameMainViewPanel.Controls.Add(TurnTrackerLabel);
            GameMainViewPanel.Controls.Add(Enemy3HealthBox);
            GameMainViewPanel.Controls.Add(Enemy2HealthBox);
            GameMainViewPanel.Controls.Add(Enemy1HealthBox);
            GameMainViewPanel.Controls.Add(Ally1HealthBox);
            GameMainViewPanel.Controls.Add(Ally2HealthBox);
            GameMainViewPanel.Controls.Add(Enemy3IntBox);
            GameMainViewPanel.Controls.Add(Enemy2IntBox);
            GameMainViewPanel.Controls.Add(Enemy1IntBox);
            GameMainViewPanel.Controls.Add(Ally1IntBox);
            GameMainViewPanel.Controls.Add(Ally2IntBox);
            GameMainViewPanel.Controls.Add(Enemy3AtkBox);
            GameMainViewPanel.Controls.Add(Enemy2AtkBox);
            GameMainViewPanel.Controls.Add(Enemy1AtkBox);
            GameMainViewPanel.Controls.Add(Ally1AtkBox);
            GameMainViewPanel.Controls.Add(Ally2AtkBox);
            GameMainViewPanel.Controls.Add(Ally3IntBox);
            GameMainViewPanel.Controls.Add(Ally3AtkBox);
            GameMainViewPanel.Controls.Add(Ally3HealthBox);
            GameMainViewPanel.Controls.Add(Enemy3Panel);
            GameMainViewPanel.Controls.Add(Enemy2Panel);
            GameMainViewPanel.Controls.Add(Ally3Panel);
            GameMainViewPanel.Controls.Add(Ally2Panel);
            GameMainViewPanel.Controls.Add(CombatAbilityPanel);
            GameMainViewPanel.Controls.Add(Enemy1Panel);
            GameMainViewPanel.Controls.Add(Ally1Panel);
            GameMainViewPanel.Dock = DockStyle.Right;
            GameMainViewPanel.Location = new Point(200, 25);
            GameMainViewPanel.Name = "GameMainViewPanel";
            GameMainViewPanel.Size = new Size(600, 450);
            GameMainViewPanel.TabIndex = 15;
            // 
            // TurnTrackerLabel
            // 
            TurnTrackerLabel.AutoSize = true;
            TurnTrackerLabel.BackColor = Color.Transparent;
            TurnTrackerLabel.ForeColor = Color.Cyan;
            TurnTrackerLabel.Location = new Point(3, 6);
            TurnTrackerLabel.Name = "TurnTrackerLabel";
            TurnTrackerLabel.Size = new Size(38, 20);
            TurnTrackerLabel.TabIndex = 17;
            TurnTrackerLabel.Text = "Turn";
            // 
            // Enemy3HealthBox
            // 
            Enemy3HealthBox.Location = new Point(523, 268);
            Enemy3HealthBox.Name = "Enemy3HealthBox";
            Enemy3HealthBox.ReadOnly = true;
            Enemy3HealthBox.Size = new Size(31, 27);
            Enemy3HealthBox.TabIndex = 3;
            Enemy3HealthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy2HealthBox
            // 
            Enemy2HealthBox.Location = new Point(442, 268);
            Enemy2HealthBox.Name = "Enemy2HealthBox";
            Enemy2HealthBox.ReadOnly = true;
            Enemy2HealthBox.Size = new Size(30, 27);
            Enemy2HealthBox.TabIndex = 3;
            Enemy2HealthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy1HealthBox
            // 
            Enemy1HealthBox.Location = new Point(361, 268);
            Enemy1HealthBox.Name = "Enemy1HealthBox";
            Enemy1HealthBox.ReadOnly = true;
            Enemy1HealthBox.Size = new Size(34, 27);
            Enemy1HealthBox.TabIndex = 4;
            Enemy1HealthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally1HealthBox
            // 
            Ally1HealthBox.Location = new Point(204, 268);
            Ally1HealthBox.Name = "Ally1HealthBox";
            Ally1HealthBox.ReadOnly = true;
            Ally1HealthBox.Size = new Size(30, 27);
            Ally1HealthBox.TabIndex = 3;
            Ally1HealthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally2HealthBox
            // 
            Ally2HealthBox.Location = new Point(123, 268);
            Ally2HealthBox.Name = "Ally2HealthBox";
            Ally2HealthBox.ReadOnly = true;
            Ally2HealthBox.Size = new Size(34, 27);
            Ally2HealthBox.TabIndex = 3;
            Ally2HealthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy3IntBox
            // 
            Enemy3IntBox.Location = new Point(502, 268);
            Enemy3IntBox.Name = "Enemy3IntBox";
            Enemy3IntBox.ReadOnly = true;
            Enemy3IntBox.Size = new Size(24, 27);
            Enemy3IntBox.TabIndex = 16;
            Enemy3IntBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy2IntBox
            // 
            Enemy2IntBox.Location = new Point(421, 268);
            Enemy2IntBox.Name = "Enemy2IntBox";
            Enemy2IntBox.ReadOnly = true;
            Enemy2IntBox.Size = new Size(24, 27);
            Enemy2IntBox.TabIndex = 15;
            Enemy2IntBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy1IntBox
            // 
            Enemy1IntBox.Location = new Point(340, 268);
            Enemy1IntBox.Name = "Enemy1IntBox";
            Enemy1IntBox.ReadOnly = true;
            Enemy1IntBox.Size = new Size(24, 27);
            Enemy1IntBox.TabIndex = 14;
            Enemy1IntBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally1IntBox
            // 
            Ally1IntBox.Location = new Point(234, 268);
            Ally1IntBox.Name = "Ally1IntBox";
            Ally1IntBox.ReadOnly = true;
            Ally1IntBox.Size = new Size(24, 27);
            Ally1IntBox.TabIndex = 13;
            Ally1IntBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally2IntBox
            // 
            Ally2IntBox.Location = new Point(153, 268);
            Ally2IntBox.Name = "Ally2IntBox";
            Ally2IntBox.ReadOnly = true;
            Ally2IntBox.Size = new Size(24, 27);
            Ally2IntBox.TabIndex = 12;
            Ally2IntBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy3AtkBox
            // 
            Enemy3AtkBox.Location = new Point(553, 268);
            Enemy3AtkBox.Name = "Enemy3AtkBox";
            Enemy3AtkBox.ReadOnly = true;
            Enemy3AtkBox.Size = new Size(24, 27);
            Enemy3AtkBox.TabIndex = 11;
            Enemy3AtkBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy2AtkBox
            // 
            Enemy2AtkBox.Location = new Point(472, 268);
            Enemy2AtkBox.Name = "Enemy2AtkBox";
            Enemy2AtkBox.ReadOnly = true;
            Enemy2AtkBox.Size = new Size(24, 27);
            Enemy2AtkBox.TabIndex = 10;
            Enemy2AtkBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy1AtkBox
            // 
            Enemy1AtkBox.Location = new Point(391, 268);
            Enemy1AtkBox.Name = "Enemy1AtkBox";
            Enemy1AtkBox.ReadOnly = true;
            Enemy1AtkBox.Size = new Size(24, 27);
            Enemy1AtkBox.TabIndex = 9;
            Enemy1AtkBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally1AtkBox
            // 
            Ally1AtkBox.Location = new Point(183, 268);
            Ally1AtkBox.Name = "Ally1AtkBox";
            Ally1AtkBox.ReadOnly = true;
            Ally1AtkBox.Size = new Size(24, 27);
            Ally1AtkBox.TabIndex = 8;
            Ally1AtkBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally2AtkBox
            // 
            Ally2AtkBox.Location = new Point(102, 268);
            Ally2AtkBox.Name = "Ally2AtkBox";
            Ally2AtkBox.ReadOnly = true;
            Ally2AtkBox.Size = new Size(24, 27);
            Ally2AtkBox.TabIndex = 7;
            Ally2AtkBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally3IntBox
            // 
            Ally3IntBox.Location = new Point(74, 268);
            Ally3IntBox.Name = "Ally3IntBox";
            Ally3IntBox.ReadOnly = true;
            Ally3IntBox.Size = new Size(24, 27);
            Ally3IntBox.TabIndex = 6;
            Ally3IntBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally3AtkBox
            // 
            Ally3AtkBox.Location = new Point(23, 268);
            Ally3AtkBox.Name = "Ally3AtkBox";
            Ally3AtkBox.ReadOnly = true;
            Ally3AtkBox.Size = new Size(24, 27);
            Ally3AtkBox.TabIndex = 5;
            Ally3AtkBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally3HealthBox
            // 
            Ally3HealthBox.Location = new Point(44, 268);
            Ally3HealthBox.Name = "Ally3HealthBox";
            Ally3HealthBox.ReadOnly = true;
            Ally3HealthBox.Size = new Size(34, 27);
            Ally3HealthBox.TabIndex = 3;
            Ally3HealthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Enemy3Panel
            // 
            Enemy3Panel.BackColor = Color.Transparent;
            Enemy3Panel.BackgroundImage = Properties.Resources.charsets_12_m_f_complete_by_antifarea_2_;
            Enemy3Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Enemy3Panel.Location = new Point(502, 146);
            Enemy3Panel.Name = "Enemy3Panel";
            Enemy3Panel.Size = new Size(75, 125);
            Enemy3Panel.TabIndex = 4;
            // 
            // Enemy2Panel
            // 
            Enemy2Panel.BackColor = Color.Transparent;
            Enemy2Panel.BackgroundImage = Properties.Resources.charsets_12_m_f_complete_by_antifarea_2_;
            Enemy2Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Enemy2Panel.Location = new Point(421, 146);
            Enemy2Panel.Name = "Enemy2Panel";
            Enemy2Panel.Size = new Size(75, 125);
            Enemy2Panel.TabIndex = 4;
            // 
            // Ally3Panel
            // 
            Ally3Panel.BackColor = Color.Transparent;
            Ally3Panel.BackgroundImage = Properties.Resources.charsets_12_m_f_complete_by_antifarea_2_;
            Ally3Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Ally3Panel.Location = new Point(23, 146);
            Ally3Panel.Name = "Ally3Panel";
            Ally3Panel.Size = new Size(75, 125);
            Ally3Panel.TabIndex = 4;
            // 
            // Ally2Panel
            // 
            Ally2Panel.BackColor = Color.Transparent;
            Ally2Panel.BackgroundImage = Properties.Resources.charsets_12_m_f_complete_by_antifarea_2_;
            Ally2Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Ally2Panel.Location = new Point(102, 146);
            Ally2Panel.Name = "Ally2Panel";
            Ally2Panel.Size = new Size(75, 125);
            Ally2Panel.TabIndex = 4;
            // 
            // CombatAbilityPanel
            // 
            CombatAbilityPanel.BackgroundImage = Properties.Resources.wood_background;
            CombatAbilityPanel.Controls.Add(AbilityHideButton);
            CombatAbilityPanel.Controls.Add(Ability4Button);
            CombatAbilityPanel.Controls.Add(Ability3Button);
            CombatAbilityPanel.Controls.Add(Ability2Button);
            CombatAbilityPanel.Controls.Add(Ability1Button);
            CombatAbilityPanel.Location = new Point(0, 323);
            CombatAbilityPanel.Name = "CombatAbilityPanel";
            CombatAbilityPanel.Size = new Size(600, 127);
            CombatAbilityPanel.TabIndex = 2;
            // 
            // AbilityHideButton
            // 
            AbilityHideButton.BackColor = Color.Transparent;
            AbilityHideButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            AbilityHideButton.BackgroundImageLayout = ImageLayout.Stretch;
            AbilityHideButton.FlatAppearance.BorderSize = 0;
            AbilityHideButton.FlatStyle = FlatStyle.Flat;
            AbilityHideButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AbilityHideButton.ForeColor = Color.Cyan;
            AbilityHideButton.Location = new Point(401, 40);
            AbilityHideButton.Name = "AbilityHideButton";
            AbilityHideButton.Size = new Size(170, 45);
            AbilityHideButton.TabIndex = 11;
            AbilityHideButton.Text = "Close";
            AbilityHideButton.UseVisualStyleBackColor = false;
            AbilityHideButton.Click += AbilityHideButton_Click;
            // 
            // Ability4Button
            // 
            Ability4Button.BackColor = Color.Transparent;
            Ability4Button.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            Ability4Button.BackgroundImageLayout = ImageLayout.Stretch;
            Ability4Button.FlatAppearance.BorderSize = 0;
            Ability4Button.FlatStyle = FlatStyle.Flat;
            Ability4Button.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ability4Button.ForeColor = Color.Cyan;
            Ability4Button.Location = new Point(225, 70);
            Ability4Button.Name = "Ability4Button";
            Ability4Button.Size = new Size(170, 45);
            Ability4Button.TabIndex = 10;
            Ability4Button.Text = "Placeholder";
            Ability4Button.UseVisualStyleBackColor = false;
            // 
            // Ability3Button
            // 
            Ability3Button.BackColor = Color.Transparent;
            Ability3Button.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            Ability3Button.BackgroundImageLayout = ImageLayout.Stretch;
            Ability3Button.FlatAppearance.BorderSize = 0;
            Ability3Button.FlatStyle = FlatStyle.Flat;
            Ability3Button.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ability3Button.ForeColor = Color.Cyan;
            Ability3Button.Location = new Point(23, 70);
            Ability3Button.Name = "Ability3Button";
            Ability3Button.Size = new Size(170, 45);
            Ability3Button.TabIndex = 9;
            Ability3Button.Text = "Placeholder";
            Ability3Button.UseVisualStyleBackColor = false;
            // 
            // Ability2Button
            // 
            Ability2Button.BackColor = Color.Transparent;
            Ability2Button.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            Ability2Button.BackgroundImageLayout = ImageLayout.Stretch;
            Ability2Button.FlatAppearance.BorderSize = 0;
            Ability2Button.FlatStyle = FlatStyle.Flat;
            Ability2Button.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ability2Button.ForeColor = Color.Cyan;
            Ability2Button.Location = new Point(225, 14);
            Ability2Button.Name = "Ability2Button";
            Ability2Button.Size = new Size(170, 45);
            Ability2Button.TabIndex = 8;
            Ability2Button.Text = "Special Attack";
            Ability2Button.UseVisualStyleBackColor = false;
            Ability2Button.Click += Ability2Button_Click;
            // 
            // Ability1Button
            // 
            Ability1Button.BackColor = Color.Transparent;
            Ability1Button.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            Ability1Button.BackgroundImageLayout = ImageLayout.Stretch;
            Ability1Button.FlatAppearance.BorderSize = 0;
            Ability1Button.FlatStyle = FlatStyle.Flat;
            Ability1Button.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ability1Button.ForeColor = Color.Cyan;
            Ability1Button.Location = new Point(23, 14);
            Ability1Button.Name = "Ability1Button";
            Ability1Button.Size = new Size(170, 45);
            Ability1Button.TabIndex = 7;
            Ability1Button.Text = "Basic Attack";
            Ability1Button.UseVisualStyleBackColor = false;
            Ability1Button.Click += Ability1Button_Click;
            // 
            // Enemy1Panel
            // 
            Enemy1Panel.BackColor = Color.Transparent;
            Enemy1Panel.BackgroundImage = Properties.Resources.charsets_12_m_f_complete_by_antifarea_2_;
            Enemy1Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Enemy1Panel.Location = new Point(340, 146);
            Enemy1Panel.Name = "Enemy1Panel";
            Enemy1Panel.Size = new Size(75, 125);
            Enemy1Panel.TabIndex = 1;
            // 
            // Ally1Panel
            // 
            Ally1Panel.BackColor = Color.Transparent;
            Ally1Panel.BackgroundImage = Properties.Resources.charsets_12_m_f_complete_by_antifarea_2_;
            Ally1Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Ally1Panel.Location = new Point(183, 146);
            Ally1Panel.Name = "Ally1Panel";
            Ally1Panel.Size = new Size(75, 125);
            Ally1Panel.TabIndex = 0;
            // 
            // Enemy1Indicator
            // 
            Enemy1Indicator.Location = new Point(350, 111);
            Enemy1Indicator.Name = "Enemy1Indicator";
            Enemy1Indicator.Size = new Size(54, 29);
            Enemy1Indicator.TabIndex = 18;
            Enemy1Indicator.Text = "button1";
            Enemy1Indicator.UseVisualStyleBackColor = true;
            // 
            // Enemy2Indicator
            // 
            Enemy2Indicator.Location = new Point(431, 111);
            Enemy2Indicator.Name = "Enemy2Indicator";
            Enemy2Indicator.Size = new Size(54, 29);
            Enemy2Indicator.TabIndex = 19;
            Enemy2Indicator.Text = "button1";
            Enemy2Indicator.UseVisualStyleBackColor = true;
            // 
            // Enemy3Indicator
            // 
            Enemy3Indicator.Location = new Point(505, 111);
            Enemy3Indicator.Name = "Enemy3Indicator";
            Enemy3Indicator.Size = new Size(54, 29);
            Enemy3Indicator.TabIndex = 20;
            Enemy3Indicator.Text = "button1";
            Enemy3Indicator.UseVisualStyleBackColor = true;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(GameMainViewPanel);
            Controls.Add(GameMainMenuPanel);
            Controls.Add(TopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CombatForm";
            Text = "CombatForm";
            TopBarPanel.ResumeLayout(false);
            GameMainMenuPanel.ResumeLayout(false);
            GameMainViewPanel.ResumeLayout(false);
            GameMainViewPanel.PerformLayout();
            CombatAbilityPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBarPanel;
        private Button ExitButton;
        private Panel GameMainMenuPanel;
        private Button AbbilitiesButton;
        private Button BackButton;
        private Panel GameMainViewPanel;
        private Panel Enemy1Panel;
        private Panel Ally1Panel;
        private Button CharactersButton;
        private Panel CombatAbilityPanel;
        private Button Ability1Button;
        private Button Ability4Button;
        private Button Ability3Button;
        private Button Ability2Button;
        private Button AbilityHideButton;
        private TextBox Enemy1HealthBox;
        private TextBox Ally1HealthBox;
        private Panel Enemy2Panel;
        private TextBox Enemy2HealthBox;
        private Panel Ally3Panel;
        private TextBox Ally3HealthBox;
        private Panel Ally2Panel;
        private TextBox Ally2HealthBox;
        private Panel Enemy3Panel;
        private TextBox Enemy3HealthBox;
        private TextBox Enemy3AtkBox;
        private TextBox Enemy2AtkBox;
        private TextBox Enemy1AtkBox;
        private TextBox Ally1AtkBox;
        private TextBox Ally2AtkBox;
        private TextBox Ally3IntBox;
        private TextBox Ally3AtkBox;
        private TextBox Enemy3IntBox;
        private TextBox Enemy2IntBox;
        private TextBox Enemy1IntBox;
        private TextBox Ally1IntBox;
        private TextBox Ally2IntBox;
        private Label TurnTrackerLabel;
        private Button Enemy1Indicator;
        private Button Enemy3Indicator;
        private Button Enemy2Indicator;
    }
}