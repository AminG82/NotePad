﻿using System.Configuration;

namespace NotePad
{
    public partial class FindForm : Form
    {
        Form1 Form1;
        TextBox txtText;

        public FindForm(Form1 form, TextBox text)
        {
            Form1 = form;
            txtText = text;
            txtText.SelectionStart = 0;
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form1.Find(txtFind.Text.ToLower());
            Form1.Focus();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (txtReplace.Text.Length > 0)
            {
                Form1.Replace(txtFind.Text.ToLower(), txtReplace.Text);
                Form1.Focus();
            }
            else
            {
                MessageBox.Show("please Enter a valid Data to Replace!");
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)
            {
                Form1.Find(txtFind.Text.ToLower() , ++txtText.SelectionStart);
                Form1.Focus();
            }
            else
            {
                MessageBox.Show("please Enter a valid Data to Find!");
            }

        }
    }
}
