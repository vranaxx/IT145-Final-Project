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

            this.TopBarPanel.MouseDown += new MouseEventHandler(TopBar_MouseDown); //TBS: Part of the form moving event
        }

        private void CharacterCreation_Load(object sender, EventArgs e) //TBS
        {
        }
        private void createcharButton_Click(object sender, EventArgs e) //TBS
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

            createdChar.CharacterSetBasicIngredient(
                Ingredient.basicIngredients[Random.Shared.Next(Ingredient.basicIngredients.Count)]
                );

            Character._characterList.Add(createdChar);

            MessageBox.Show("Character created successfully!");
        }

        private void displayprofstatButton_Click(object sender, EventArgs e) //TBS
        {
            if (createdChar == null)
            {
                MessageBox.Show("Error: No character created yet!");
                return;
            }

            var charStats = createdChar.GetBasicIngredientStats();

            MessageBox.Show(
                $"Name: {createdChar.CharacterGetName()}\n" +
                $"Profession: {createdChar.GetProfessionName()}\n" +
                $"ATK: {createdChar.GetProfessionATK()}\n" +
                $"HP: {createdChar.GetProfessionHP()}\n" +
                $"INT: {createdChar.GetProfessionINT()}\n" +
                $"Ingredient 1: {createdChar.GetBasicIngredientName()}: (ATK: {charStats.ATK} HP: {charStats.HP} INT: {charStats.INT})"

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
