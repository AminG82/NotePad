using System.Configuration;

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
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form1.Find(txtFind.Text);
            Form1.Focus();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (txtReplace.Text.Length > 0)
            {
                Form1.Replace(txtFind.Text, txtReplace.Text);
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
                Form1.Find(txtFind.Text , ++txtText.SelectionStart);
                Form1.Focus();
            }
            else
            {
                MessageBox.Show("please Enter a valid Data to Find!");
            }

        }
    }
}
