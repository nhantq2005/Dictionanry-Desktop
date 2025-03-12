using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Dictionary_Desktop
{
    public class ManageData
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();

        public Dictionary<string, string> Data { 
            get {  return data; } 
            set { data = value; }
        }

        public void ImportData(string path)
        {
            string errorKey = "";
            //Đọc file
            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] pair = line.Split(':');
                        errorKey = pair[0];
                        data.Add(pair[0].ToLower(), pair[1]);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine(errorKey);
                }
                //Check định dạng file
                catch(IndexOutOfRangeException) 
                {
                    MessageBox.Show(
                        "Định dạng nội dung tệp không hợp lệ!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        public string GetMeaning(string word)
        {

            try
            {
                return data[word.ToLower()];
                //Trường hợp từ không có trong Dictionary
            }catch(KeyNotFoundException)
            {
                if (data.Keys.Count == 0)
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu","Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    return "Từ không tồn tại";
                }
            }
            return "";
        }

        public string GetWordByMeaning(string meaning)
        {
            //Bỏ khoảng trắng đầu cuối
            meaning = meaning.Trim().ToLower();
            return data.FirstOrDefault(word => word.Value == meaning).Key;
        }

        public void EditWord(string word, string meaning)
        {
            data[word]=meaning.ToLower();
        }

        public void DeleteWord(string word)
        {
            data.Remove(word.ToLower());
        }

        public void AddWord(string word, string meaning)
        {
            if (!data.ContainsKey(word))
            {
                data.Add(word.ToLower(), meaning.ToLower());
            }
            else
            {
                data[word.ToLower()] = meaning.ToLower();
            }
        }

        public void ExportData()
        {

        }
    }
}
