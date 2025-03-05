using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Desktop
{
    public partial class Form1 : Form
    {
        QuanLyDL ql = new QuanLyDL();
        public Form1()
        {
            InitializeComponent();

            ql.ImportData();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            output.Text=ql.LookUpWord(input.Text);

        }

    }
}
