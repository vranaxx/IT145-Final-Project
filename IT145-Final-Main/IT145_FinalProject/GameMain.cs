using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace IT145_FinalProject
{
    public partial class GameMain : Form
    {
        #region Windows API Import for Form drag

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion
        public GameMain()
        {
            InitializeComponent();

            this.TopBarPanel.MouseDown += new MouseEventHandler(TopBar_MouseDown); //TBS: Part of the form moving event

        }

        private void GameMain_Load(object sender, EventArgs e)
        {

        }
        private void TopBar_MouseDown(object sender, MouseEventArgs e) //TBS: Event for mooving form
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e) //TBS: Exits Application
        {
            Application.Exit();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CharacterButton_Click(object sender, EventArgs e)
        {
            CharacterList characterlist = new CharacterList();

            characterlist.StartPosition = FormStartPosition.Manual;

            characterlist.Location = this.Location;

            characterlist.FormClosed += (s, args) => this.Show();

            this.Hide();

            characterlist.Show();
        }
    }
}
