namespace NotePad
{
    public partial class FindForm : Form
    {
        Form1 Form1;
        public FindForm(Form1 form)
        {
            Form1 = form;
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form1.Find(txtFind.Text);
            Form1.Focus();
        }
    }
}
