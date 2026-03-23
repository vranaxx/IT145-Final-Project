using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IT145_FinalProject
{
    public partial class TitleForm : Form
    {
        private Character createdChar;
        public TitleForm()
        {
            InitializeComponent();
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {

        }

        private void createcharButton_Click(object sender, EventArgs     e)
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
    }
}
