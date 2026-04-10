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
    public partial class CombatForm : Form
    {
        #region Windows API Import for Form drag

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion
        public CombatForm()
        {
            InitializeComponent();

            this.TopBarPanel.MouseDown += new MouseEventHandler(TopBar_MouseDown); //TBS: Part of the form moving event

            CombatAbilityPanel.Hide();

            #region Enemy Char Initialize

            Profession professionSelection1 = Profession.GetCharacterProffesionRandom();
            Ingredient randomingredient1 = Ingredient.GetIngredientRandom();
            Character rndenemy1 = new Character(professionSelection1, "enemy1", randomingredient1);

            Profession professionSelection2 = Profession.GetCharacterProffesionRandom();
            Ingredient randomingredient2 = Ingredient.GetIngredientRandom();
            Character rndenemy2 = new Character(professionSelection2, "enemy2", randomingredient2);

            Profession professionSelection3 = Profession.GetCharacterProffesionRandom();
            Ingredient randomingredient3 = Ingredient.GetIngredientRandom();
            Character rndenemy3 = new Character(professionSelection3, "enemy3", randomingredient3);

            Character._characterEnemyList.Add(rndenemy1);
            Character._characterEnemyList.Add(rndenemy2);
            Character._characterEnemyList.Add(rndenemy3);

            #endregion

            #region Initialize Health Box

            int charactercountswitch = Character._characterList.Count;

            switch (charactercountswitch)
            {
                case 1:
                    Ally1HealthBox.Text = Convert.ToString(Character._characterList[0].GetCharacterHP());
                    break;
                case 2:
                    Ally1HealthBox.Text = Convert.ToString(Character._characterList[0].GetCharacterHP());
                    Ally2HealthBox.Text = Convert.ToString(Character._characterList[1].GetCharacterHP());
                    break;
                case 3:
                    Ally1HealthBox.Text = Convert.ToString(Character._characterList[0].GetCharacterHP());
                    Ally2HealthBox.Text = Convert.ToString(Character._characterList[1].GetCharacterHP());
                    Ally3HealthBox.Text = Convert.ToString(Character._characterList[2].GetCharacterHP());
                    break;
                default:
                    break;
            }

            int enemycharswitch = Character._characterEnemyList.Count;

            switch (enemycharswitch)
            {
                case 1:
                    Enemy1HealthBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterHP());
                    break;
                case 2:
                    Enemy1HealthBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterHP());
                    Enemy2HealthBox.Text = Convert.ToString(Character._characterEnemyList[1].GetCharacterHP());
                    break;
                case 3:
                    Enemy1HealthBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterHP());
                    Enemy2HealthBox.Text = Convert.ToString(Character._characterEnemyList[1].GetCharacterHP());
                    Enemy3HealthBox.Text = Convert.ToString(Character._characterEnemyList[2].GetCharacterHP());
                    break;
                default:
                    break;
            }

            #endregion

            #region Initialize Atk Box

            switch (charactercountswitch)
            {
                case 1:
                    Ally1AtkBox.Text = Convert.ToString(Character._characterList[0].GetCharacterATK());
                    break;
                case 2:
                    Ally1AtkBox.Text = Convert.ToString(Character._characterList[0].GetCharacterATK());
                    Ally2AtkBox.Text = Convert.ToString(Character._characterList[1].GetCharacterATK());
                    break;
                case 3:
                    Ally1AtkBox.Text = Convert.ToString(Character._characterList[0].GetCharacterATK());
                    Ally2AtkBox.Text = Convert.ToString(Character._characterList[1].GetCharacterATK());
                    Ally3AtkBox.Text = Convert.ToString(Character._characterList[2].GetCharacterATK());
                    break;
                default:
                    break;
            }

            switch (enemycharswitch)
            {
                case 1:
                    Enemy1AtkBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterATK());
                    break;
                case 2:
                    Enemy1AtkBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterATK());
                    Enemy2AtkBox.Text = Convert.ToString(Character._characterEnemyList[1].GetCharacterATK());
                    break;
                case 3:
                    Enemy1AtkBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterATK());
                    Enemy2AtkBox.Text = Convert.ToString(Character._characterEnemyList[1].GetCharacterATK());
                    Enemy3AtkBox.Text = Convert.ToString(Character._characterEnemyList[2].GetCharacterATK());
                    break;
                default:
                    break;
            }

                    #endregion

            #region Initialize Int Box

                switch (charactercountswitch)
            {
            case 1:
                Ally1IntBox.Text = Convert.ToString(Character._characterList[0].GetCharacterINT());
                break;
            case 2:
                Ally1IntBox.Text = Convert.ToString(Character._characterList[0].GetCharacterINT());
                Ally2IntBox.Text = Convert.ToString(Character._characterList[1].GetCharacterINT());
                break;
            case 3:
                Ally1IntBox.Text = Convert.ToString(Character._characterList[0].GetCharacterINT());
                Ally2IntBox.Text = Convert.ToString(Character._characterList[1].GetCharacterINT());
                Ally3IntBox.Text = Convert.ToString(Character._characterList[2].GetCharacterINT());
                break;
            default:
                break;
            }

            switch (enemycharswitch)
            {
                case 1:
                    Enemy1IntBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterINT());
                    break;
                case 2:
                    Enemy1IntBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterINT());
                    Enemy2IntBox.Text = Convert.ToString(Character._characterEnemyList[1].GetCharacterINT());
                    break;
                case 3:
                    Enemy1IntBox.Text = Convert.ToString(Character._characterEnemyList[0].GetCharacterINT());
                    Enemy2IntBox.Text = Convert.ToString(Character._characterEnemyList[1].GetCharacterINT());
                    Enemy3IntBox.Text = Convert.ToString(Character._characterEnemyList[2].GetCharacterINT());
                    break;
                default:
                    break;
            }
            #endregion

            TurnTrackerLabel.Text = $"Turn: {Combat.CombatInitializeTurn()}";
        }


        private void CombatForm_Load(object sender, EventArgs e)
        {
            CombatAbilityPanel.Hide();
        }


        private void VentureButton_Click(object sender, EventArgs e)
        {

            CombatAbilityPanel.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbilityHideButton_Click(object sender, EventArgs e)
        {
            CombatAbilityPanel.Hide();

        }

        private void Ability2Button_Click(object sender, EventArgs e)
        {

        }

        private void Ability1Button_Click(object sender, EventArgs e)
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
