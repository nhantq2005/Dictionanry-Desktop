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
        ManageData md = new ManageData();
        public Form1()
        {
            InitializeComponent();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP TỪ");
            }
            else if (rdENtoVN.Checked)
            {
                output.Text = md.GetMeaning(input.Text);
            }
            else
            {
                output.Text = md.GetWordByMeaning(input.Text);
            }

        }

        private void editDataItem_Click(object sender, EventArgs e)
        {
            EditDataForm edf = new EditDataForm();
            edf.ShowDialog();
            
        }

        private void importData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                md.ImportData(ofd.FileName);
            }
        }

        private void editDataItem_Click_1(object sender, EventArgs e)
        {
            EditDataForm edf = new EditDataForm(md);
            edf.ShowDialog();
        }

        private void showDataItem_Click(object sender, EventArgs e)
        {
            ViewDataForm vdf= new ViewDataForm(md);
            vdf.ShowDialog();
        }
    }
}
