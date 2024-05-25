using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
        }
    }
}
