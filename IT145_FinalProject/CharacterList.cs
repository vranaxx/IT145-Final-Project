using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT145_FinalProject
{
    public partial class CharacterList : Form
    {
        #region Windows API Import for Form drag

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion
        public CharacterList()
        {
            InitializeComponent();

            this.TopBarPanel.MouseDown += new MouseEventHandler(TopBar_MouseDown); //TBS: Part of the form moving event

            CharacterListCombo.Hide();
        }
        private void TopBar_MouseDown(object sender, MouseEventArgs e) //TBS: Event for mooving form
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CreateCharButton_Click(object sender, EventArgs e)
        {
            CharacterCreation charactercreation = new CharacterCreation();

            charactercreation.StartPosition = FormStartPosition.Manual;

            charactercreation.Location = this.Location;

            charactercreation.FormClosed += (s, args) => this.Show();

            this.Hide();

            charactercreation.Show();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CharacterListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            CharacterListCombo.Show();

            CharacterListCombo.DataSource = null;

            CharacterListCombo.DataSource = Character._characterList;

            CharacterListCombo.DisplayMember = "CharacterName";
        }
    }
}
