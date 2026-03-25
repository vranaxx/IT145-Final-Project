namespace IT145_FinalProject
{
    partial class CharacterList
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
            BackButton = new Button();
            InventoryButton = new Button();
            CreateCharButton = new Button();
            GameMainViewPanel = new Panel();
            TopBarPanel.SuspendLayout();
            GameMainMenuPanel.SuspendLayout();
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
            GameMainMenuPanel.Controls.Add(BackButton);
            GameMainMenuPanel.Controls.Add(InventoryButton);
            GameMainMenuPanel.Controls.Add(CreateCharButton);
            GameMainMenuPanel.Dock = DockStyle.Left;
            GameMainMenuPanel.Location = new Point(0, 25);
            GameMainMenuPanel.Name = "GameMainMenuPanel";
            GameMainMenuPanel.Size = new Size(200, 450);
            GameMainMenuPanel.TabIndex = 13;
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
            BackButton.Text = "Main Menu";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.Transparent;
            InventoryButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            InventoryButton.BackgroundImageLayout = ImageLayout.Stretch;
            InventoryButton.FlatAppearance.BorderSize = 0;
            InventoryButton.FlatStyle = FlatStyle.Flat;
            InventoryButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryButton.ForeColor = Color.Cyan;
            InventoryButton.Location = new Point(12, 182);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(170, 45);
            InventoryButton.TabIndex = 3;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = false;
            // 
            // CreateCharButton
            // 
            CreateCharButton.BackColor = Color.Transparent;
            CreateCharButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            CreateCharButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateCharButton.FlatAppearance.BorderSize = 0;
            CreateCharButton.FlatStyle = FlatStyle.Flat;
            CreateCharButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateCharButton.ForeColor = Color.Cyan;
            CreateCharButton.Location = new Point(12, 131);
            CreateCharButton.Name = "CreateCharButton";
            CreateCharButton.Size = new Size(170, 45);
            CreateCharButton.TabIndex = 2;
            CreateCharButton.Text = "Create Character";
            CreateCharButton.UseVisualStyleBackColor = false;
            CreateCharButton.Click += CreateCharButton_Click;
            // 
            // GameMainViewPanel
            // 
            GameMainViewPanel.Dock = DockStyle.Right;
            GameMainViewPanel.Location = new Point(200, 25);
            GameMainViewPanel.Name = "GameMainViewPanel";
            GameMainViewPanel.Size = new Size(600, 450);
            GameMainViewPanel.TabIndex = 14;
            // 
            // CharacterList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(GameMainViewPanel);
            Controls.Add(GameMainMenuPanel);
            Controls.Add(TopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CharacterList";
            Text = "CharacterList";
            TopBarPanel.ResumeLayout(false);
            GameMainMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBarPanel;
        private Button ExitButton;
        private Panel GameMainMenuPanel;
        private Button BackButton;
        private Button InventoryButton;
        private Button CreateCharButton;
        private Panel GameMainViewPanel;
    }
}