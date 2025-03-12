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

        //Tải dữ liệu vào ListView
        public void LoadData(ManageData manageData)
        {
            listWord.Clear();
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

        public EditDataForm(ManageData manageData)
        {
            InitializeComponent();
            this.manageData = manageData;
        }

        //Nút đóng form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hiển thị dữ liệu khi load form
        private void EditDataForm_Load(object sender, EventArgs e)
        {
            LoadData(manageData);
        }

        //Bắt sự kiện nút thêm từ
        private void addBtn_Click(object sender, EventArgs e)
        {
            EditWordFrom ewf = new EditWordFrom(manageData,this);
            ewf.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string choosenWord = listWord.SelectedItems[0].Text;
                EditWordFrom ewf = new EditWordFrom(manageData, choosenWord);
                ewf.ShowDialog();
                this.Refresh();
            }
            catch
            {

            }
        }

        //Bắt sự kiện nút tìm kiếm
        private void searchBtn_Click(object sender, EventArgs e)
        {
            listWord.Clear();
            listWord.View = View.Details;
            listWord.Columns.Add("Từ", 200);
            listWord.Columns.Add("Nghĩa", 300);
            foreach (var word in manageData.Data)
            {
                if (word.Key.Trim().ToLower() == searchTB.Text)
                {
                    ListViewItem item = new ListViewItem(word.Key);
                    item.SubItems.Add(word.Value);
                    listWord.Items.Add(item);
                }
            }
        }

        //Bắt sự kiện nút xóa
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            for(int i = listWord.SelectedItems.Count - 1; i >= 0; i--)
            {
                listWord.Items.Remove(listWord.SelectedItems[i]);
            }
        }
    }
}
