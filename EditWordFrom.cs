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
    public partial class EditWordFrom : Form
    {
        string word;
        ManageData manageData;
        EditDataForm editDataForm;
        public EditWordFrom()
        {
            InitializeComponent();
        }

        public EditWordFrom(ManageData manageData)
        {
            InitializeComponent();
            this.manageData = manageData;
        }

        public EditWordFrom(ManageData manageData, EditDataForm editDataForm)
        {
            InitializeComponent();
            this.manageData = manageData;
            this.editDataForm = editDataForm;
        }

        public EditWordFrom(ManageData manageData, string word)
        {
            InitializeComponent();
            this.word = word;
            this.manageData=manageData;
            inputWord.Text = word;
            inputMeaning.Text = manageData.Data[word];
        }

        //Bắt sự kiện nút lưu
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (word == null)
            {
                manageData.AddWord(inputWord.Text, inputMeaning.Text);
            }
            else if (manageData.Data.ContainsKey(word))
            {
                manageData.EditWord(inputWord.Text,inputMeaning.Text);
            }
            else
            {
                manageData.AddWord(inputWord.Text,inputMeaning.Text);
            }
            this.Close();
            editDataForm.LoadData(manageData);

        }

        //Bắt sự kiện nút thoát
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
