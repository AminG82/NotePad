using Microsoft.VisualBasic.ApplicationServices;

namespace NotePad
{
    public partial class Form1 : Form
    {
        string? fileName;
        bool isSaved = true;
        ITools tools = new Tools();
        //int selectionStart = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
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

        private void open_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result;
                result = MessageBox.Show("You have unsaved data , do you want to save it first?", "Save", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    save_Click( null,null );
                }
            }
            openFileDialog1.Filter = "OnlyText (*.txt) | *.txt;*.docx";
            DialogResult openResult;
            openResult = openFileDialog1.ShowDialog();
            if (openResult == DialogResult.Cancel)
            {
                return;
            }
            fileName = openFileDialog1.FileName;
            txtBody.Text = System.IO.File.ReadAllText(fileName);
            this.Text = fileName;
            isSaved = true;
        }

        private void saveAsbtn_Click(object sender, EventArgs e)
        {
            fileName = null;        // "" can be used too !
            save_Click(null, null);
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved data , do you want to save it first?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    save_Click(null, null);
            }
            txtBody.Text = "";      //null can be use too !
            isSaved = true;
            this.Text = "NotePad";
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("You have unsaved data , do you want to save it first?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save_Click(null, null);
                }
                Application.Exit();
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBody.SelectedText);
            txtBody.SelectedText = "";  // we can use null type too !
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBody.SelectedText);
        }

        private void paste_Click(object sender, EventArgs e)
        {
            txtBody.SelectedText = Clipboard.GetText();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            txtBody.SelectAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            txtBody.SelectedText = "";
        }

        private void undo_Click(object sender, EventArgs e)
        {
            txtBody.Text = tools.Undo();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            txtBody.Text = tools.Redo();
        }

        private void txtBody_KeyUp(object sender, KeyEventArgs e)
        {
            tools.Insert(txtBody.Text);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm find = new FindForm(this , txtBody);
            find.Show();
        }
        public void Find(string text)
        {
            int index = txtBody.Text.IndexOf(text, 0);
            if (index == -1)
                MessageBox.Show("NotFound!");
            else
            {
                txtBody.SelectionStart = index;
                txtBody.SelectionLength = text.Length;
            }
        }

        public void Find(string text, int searchStart)
        {
            searchStart = txtBody.SelectionStart;
            int index = txtBody.Text.IndexOf(text, searchStart);
            if (index == -1)
                MessageBox.Show("NotFound!");
            else
            {
                txtBody.SelectionStart = index;
                txtBody.SelectionLength = text.Length;
            }
        }

        public void Replace(string text, string replace)
        {
            Find(text.ToLower());
            txtBody.SelectedText = replace;
        }

        private void txtBody_MouseDown(object sender, MouseEventArgs e)
        {
            //selectionStart = txtBody.SelectionStart;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtBody.Font = fontDialog1.Font;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtBody.ForeColor = colorDialog1.Color;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBody.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\AminG82\Config.txt", txtBody.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(@"C:\AminG82\Config.txt"))
            {
                string color = System.IO.File.ReadAllText(@"C:\AminG82\Config.txt");
                txtBody.BackColor = Color.FromName(color);
            }
        }
    }
}
