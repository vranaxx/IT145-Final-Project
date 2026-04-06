/*
 * Program:
 * Purpose: 
 * Date: 3/23/26
 * Author: Thomas Shampney
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IT145_FinalProject
{
    public partial class TitleForm : Form
    {
        #region Windows API Import for Form drag

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion
        public TitleForm()
        {
            InitializeComponent();

            // this.Load += new EventHandler(TitleForm_Load); //TBS: Open in full screen

            this.TopBarPanel.MouseDown += new MouseEventHandler(TopBar_MouseDown); //TBS: Part of the form moving event

        }

        private void TitleForm_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Normal; //TBS: Temo set windowstate to normal to ensure changes take effect
            // this.Bounds = Screen.PrimaryScreen.Bounds; //TBS: Sets form bounds to screen bounds
            // this.WindowState = FormWindowState.Maximized; //TBS: Maximize window
        }

        private void ExitButton_Click(object sender, EventArgs e) //TBS: Exits Application
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e) //TBS: Creates new instance of form and closes titleform
        {
            GameMain maingame = new GameMain();

            maingame.StartPosition = FormStartPosition.Manual;

            maingame.Location = this.Location;

            maingame.FormClosed += (s, args) => this.Show();

            this.Hide();

            maingame.Show();
        }
        private void TopBar_MouseDown(object sender, MouseEventArgs e) //TBS: Event for mooving form
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitMainButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
