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
    public partial class CharacterCreation : Form
    {
        #region Windows API Import for Form drag

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private Character createdChar;
        public CharacterCreation()
        {
            InitializeComponent();

            // this.Load += new EventHandler(CharacterCreation_Load); //TBS: Open in full screen

            this.TopBarPanel.MouseDown += new MouseEventHandler(TopBar_MouseDown); //TBS: Part of the form moving event
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            characterCombo.DataSource = Character.characterInventory;

            // this.WindowState = FormWindowState.Normal; //TBS: Temp set windowstate to normal to ensure changes take effect
            // this.Bounds = Screen.PrimaryScreen.Bounds; //TBS: Sets form bounds to screen bounds
            // this.WindowState = FormWindowState.Maximized; //TBS: Maximize window
        }
        private void createcharButton_Click(object sender, EventArgs e)
        {
            if (professionCombo.Text == "")
            {
                MessageBox.Show("Error: Empty Selection");
                return;
            }
            string tempNameSelection = charnameTxt.Text;
            string professionSelection = professionCombo.Text;
            Profession tempProfession = new Profession(professionSelection);
            
            createdChar = new Character(tempProfession, tempNameSelection);
            Character.characterInventory.Add(createdChar);

            MessageBox.Show("Character created successfully!");
        }

        private void displayprofstatButton_Click(object sender, EventArgs e)
        {
            if (createdChar == null)
            {
                MessageBox.Show("Error: No character created yet!");
                return;
            }
            MessageBox.Show(
                $"Name: {createdChar.GetCharacterName()}\n" +
                $"Profession: {createdChar.GetProfessionName()}\n" +
                $"ATK: {createdChar.GetProfessionATK()}\n" +
                $"HP: {createdChar.GetProfessionHP()}\n" +
                $"INT: {createdChar.GetProfessionINT()}"
                );
        }

        private void BackButton_Click(object sender, EventArgs e) //TBS: Returns to previous form
        {
            this.Close();
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
    }
}
