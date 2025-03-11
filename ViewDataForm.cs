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
    public partial class ViewDataForm : Form
    {
        ManageData manageData;
        public ViewDataForm()
        {
            InitializeComponent();
        }

        public ViewDataForm(ManageData manageData)
        {
            InitializeComponent();
            this.manageData = manageData;
        }

        private void ViewDataForm_Load(object sender, EventArgs e)
        {
            listWord.View = View.Details;
            listWord.Columns.Add("Từ", 200);
            listWord.Columns.Add("Nghĩa", 300);
            try
            {
                foreach (var word in manageData.Data)
                {
                    ListViewItem item = new ListViewItem(word.Key);
                    item.SubItems.Add(word.Value);
                    listWord.Items.Add(item);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("DỮ LIỆU RỖNG");
            }
        }
    }
}
