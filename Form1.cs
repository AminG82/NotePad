namespace NotePad
{
    public partial class Form1 : Form
    {
        string fileName;
        bool isSaved;
        public Form1()
        {
            InitializeComponent();
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                saveFileDialog1.Filter = "Text Only (*.txt) | *txt";
                saveFileDialog1.DefaultExt = "txt";
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                fileName = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fileName, txtBody.Text);
            this.Text = fileName;
            isSaved = true;
        }

        private void saveAsbtn_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveToolStripMenuItem_Click(null, null);
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved data , do you want to save it first?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            txtBody.Text = "";
            isSaved = false;
            this.Text = "NotePad";
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
            
        }
    }
}
