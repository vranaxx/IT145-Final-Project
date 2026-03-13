using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT145_FinalProject
{
    public partial class SubForm : Form
    {

        private Form1 prevForm;
        private bool backPressed = false;

        public SubForm()
        {
            InitializeComponent();
            prevForm = new Form1();
        }
        public SubForm(Form1 prevForm,Button sender)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            ShowText.Text = $"{sender.Name} implementation goes here...";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            backPressed = true;
            prevForm.Show();
            this.Close();
        }

        private void CloseMainForm(object sender, FormClosingEventArgs e)
        {
            if (!backPressed) // closes main form, stops debugging if x is pressed
                prevForm.Close();
        }
    }
}
