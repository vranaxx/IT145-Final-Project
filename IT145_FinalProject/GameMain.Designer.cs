namespace IT145_FinalProject
{
    partial class GameMain
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
            CharacterButton = new Button();
            RestaurantButton = new Button();
            GachaButton = new Button();
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
            // GameMainMenuPanel
            // 
            GameMainMenuPanel.BackgroundImage = Properties.Resources.paper_background;
            GameMainMenuPanel.Controls.Add(BackButton);
            GameMainMenuPanel.Controls.Add(InventoryButton);
            GameMainMenuPanel.Controls.Add(CharacterButton);
            GameMainMenuPanel.Controls.Add(RestaurantButton);
            GameMainMenuPanel.Controls.Add(GachaButton);
            GameMainMenuPanel.Dock = DockStyle.Left;
            GameMainMenuPanel.Location = new Point(0, 25);
            GameMainMenuPanel.Name = "GameMainMenuPanel";
            GameMainMenuPanel.Size = new Size(200, 450);
            GameMainMenuPanel.TabIndex = 12;
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
            BackButton.Text = "Title";
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
            InventoryButton.Location = new Point(12, 261);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(170, 45);
            InventoryButton.TabIndex = 3;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = false;
            // 
            // CharacterButton
            // 
            CharacterButton.BackColor = Color.Transparent;
            CharacterButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            CharacterButton.BackgroundImageLayout = ImageLayout.Stretch;
            CharacterButton.FlatAppearance.BorderSize = 0;
            CharacterButton.FlatStyle = FlatStyle.Flat;
            CharacterButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CharacterButton.ForeColor = Color.Cyan;
            CharacterButton.Location = new Point(12, 210);
            CharacterButton.Name = "CharacterButton";
            CharacterButton.Size = new Size(170, 45);
            CharacterButton.TabIndex = 2;
            CharacterButton.Text = "Characters";
            CharacterButton.UseVisualStyleBackColor = false;
            CharacterButton.Click += CharacterButton_Click;
            // 
            // RestaurantButton
            // 
            RestaurantButton.BackColor = Color.Transparent;
            RestaurantButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            RestaurantButton.BackgroundImageLayout = ImageLayout.Stretch;
            RestaurantButton.FlatAppearance.BorderSize = 0;
            RestaurantButton.FlatStyle = FlatStyle.Flat;
            RestaurantButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RestaurantButton.ForeColor = Color.Cyan;
            RestaurantButton.Location = new Point(12, 159);
            RestaurantButton.Name = "RestaurantButton";
            RestaurantButton.Size = new Size(170, 45);
            RestaurantButton.TabIndex = 1;
            RestaurantButton.Text = "Restaurant";
            RestaurantButton.UseVisualStyleBackColor = false;
            // 
            // GachaButton
            // 
            GachaButton.BackColor = Color.Transparent;
            GachaButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            GachaButton.BackgroundImageLayout = ImageLayout.Stretch;
            GachaButton.FlatAppearance.BorderSize = 0;
            GachaButton.FlatStyle = FlatStyle.Flat;
            GachaButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GachaButton.ForeColor = Color.Cyan;
            GachaButton.Location = new Point(12, 108);
            GachaButton.Name = "GachaButton";
            GachaButton.Size = new Size(170, 45);
            GachaButton.TabIndex = 0;
            GachaButton.Text = "Gacha";
            GachaButton.UseVisualStyleBackColor = false;
            // 
            // GameMainViewPanel
            // 
            GameMainViewPanel.Dock = DockStyle.Right;
            GameMainViewPanel.Location = new Point(200, 25);
            GameMainViewPanel.Name = "GameMainViewPanel";
            GameMainViewPanel.Size = new Size(600, 450);
            GameMainViewPanel.TabIndex = 13;
            // 
            // GameMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(GameMainViewPanel);
            Controls.Add(GameMainMenuPanel);
            Controls.Add(TopBarPanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameMain";
            Text = "GameMain";
            Load += GameMain_Load;
            TopBarPanel.ResumeLayout(false);
            GameMainMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBarPanel;
        private Button ExitButton;
        private Panel GameMainMenuPanel;
        private Panel GameMainViewPanel;
        private Button GachaButton;
        private Button BackButton;
        private Button InventoryButton;
        private Button CharacterButton;
        private Button RestaurantButton;
    }
}