using System;
using System.Collections;
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
    public partial class EditDataForm : Form
    {
        ManageData manageData;
        
        public EditDataForm()
        {
            InitializeComponent();
            
        }


        public EditDataForm(ManageData manageData)
        {
            InitializeComponent();
            this.manageData = manageData;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDataForm_Load(object sender, EventArgs e)
        {
            listWord.View = View.Details;
            listWord.Columns.Add("Từ", 200);
            listWord.Columns.Add("Nghĩa", 300);
            foreach (var word in manageData.Data)
            {
                ListViewItem item = new ListViewItem(word.Key);
                item.SubItems.Add(word.Value);
                listWord.Items.Add(item);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditWordFrom ewf = new EditWordFrom(manageData);
            ewf.ShowDialog();
            this.Refresh();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string choosenWord = listWord.SelectedItems[0].Text;
            EditWordFrom ewf = new EditWordFrom(manageData, choosenWord);
            ewf.ShowDialog();
            this.Refresh();
        }
    }
}
