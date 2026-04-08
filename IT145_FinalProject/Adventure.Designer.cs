namespace IT145_FinalProject
{
    partial class Adventure
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
            TravelButton = new Button();
            BackButton = new Button();
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
            GameMainMenuPanel.Controls.Add(TravelButton);
            GameMainMenuPanel.Controls.Add(BackButton);
            GameMainMenuPanel.Dock = DockStyle.Left;
            GameMainMenuPanel.Location = new Point(0, 25);
            GameMainMenuPanel.Name = "GameMainMenuPanel";
            GameMainMenuPanel.Size = new Size(200, 450);
            GameMainMenuPanel.TabIndex = 13;
            // 
            // TravelButton
            // 
            TravelButton.BackColor = Color.Transparent;
            TravelButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            TravelButton.BackgroundImageLayout = ImageLayout.Stretch;
            TravelButton.FlatAppearance.BorderSize = 0;
            TravelButton.FlatStyle = FlatStyle.Flat;
            TravelButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TravelButton.ForeColor = Color.Cyan;
            TravelButton.Location = new Point(12, 6);
            TravelButton.Name = "TravelButton";
            TravelButton.Size = new Size(170, 45);
            TravelButton.TabIndex = 5;
            TravelButton.Text = "Travel";
            TravelButton.UseVisualStyleBackColor = false;
            TravelButton.Click += TravelButton_Click;
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
            GameMainViewPanel.Dock = DockStyle.Right;
            GameMainViewPanel.Location = new Point(200, 25);
            GameMainViewPanel.Name = "GameMainViewPanel";
            GameMainViewPanel.Size = new Size(600, 450);
            GameMainViewPanel.TabIndex = 14;
            // 
            // Adventure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(GameMainViewPanel);
            Controls.Add(GameMainMenuPanel);
            Controls.Add(TopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adventure";
            Text = "Adventure";
            TopBarPanel.ResumeLayout(false);
            GameMainMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBarPanel;
        private Button ExitButton;
        private Panel GameMainMenuPanel;
        private Button TravelButton;
        private Button BackButton;
        private Panel GameMainViewPanel;
    }
}