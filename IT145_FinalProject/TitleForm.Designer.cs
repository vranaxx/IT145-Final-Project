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
            ExitButton = new Button();
            TitleScreenLabel = new Label();
            StartButton = new Button();
            TopBarPanel = new Panel();
            TopBarPanel.SuspendLayout();
            SuspendLayout();
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
            // TitleScreenLabel
            // 
            TitleScreenLabel.AutoSize = true;
            TitleScreenLabel.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleScreenLabel.Location = new Point(67, 84);
            TitleScreenLabel.Name = "TitleScreenLabel";
            TitleScreenLabel.Size = new Size(147, 37);
            TitleScreenLabel.TabIndex = 7;
            TitleScreenLabel.Text = "ProjectIT145";
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Transparent;
            StartButton.BackgroundImage = Properties.Resources.RPG_GUI_Button;
            StartButton.BackgroundImageLayout = ImageLayout.Stretch;
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.ForeColor = Color.Cyan;
            StartButton.Location = new Point(50, 192);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(164, 43);
            StartButton.TabIndex = 8;
            StartButton.Text = "St&art";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = SystemColors.ControlDarkDark;
            TopBarPanel.Controls.Add(ExitButton);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(800, 25);
            TopBarPanel.TabIndex = 10;
            // 
            // TitleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TitleScreenBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(TopBarPanel);
            Controls.Add(StartButton);
            Controls.Add(TitleScreenLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TitleForm";
            Text = "TitleForm";
            Load += TitleForm_Load;
            TopBarPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitButton;
        private Label TitleScreenLabel;
        private Button StartButton;
        private Panel TopBarPanel;
    }
}