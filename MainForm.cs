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
    public partial class MainForm : Form
    {
        ManageData manageData = new ManageData();
        public MainForm()
        {
            InitializeComponent();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            //Thông báo khi người dùng chưa nhập từ
            if (input.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP TỪ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            //Dịch từ tiếng Anh -> tiếng Việt
            else if (rdENtoVN.Checked)
            {
                output.Text = manageData.GetMeaning(input.Text);
            }
            //Dịch từ tiếng Việt -> tiếng Anh
            else
            {
                output.Text = manageData.GetWordByMeaning(input.Text);
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
            //Nhận file txt
            ofd.Filter = "Text File(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                manageData.ImportData(ofd.FileName);
            }
        }

        private void editDataItem_Click_1(object sender, EventArgs e)
        {
            EditDataForm edf = new EditDataForm(manageData);
            edf.ShowDialog();
        }

        private void showDataItem_Click(object sender, EventArgs e)
        {
            ViewDataForm vdf= new ViewDataForm(manageData);
            vdf.ShowDialog();
        }
    }
}
