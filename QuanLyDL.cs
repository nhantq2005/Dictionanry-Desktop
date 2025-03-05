using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Dictionary_Desktop
{
    internal class QuanLyDL
    {
        Dictionary<string, string> data = new Dictionary<string, string>();

        public void ImportData()
        {
            //Demo path
            string path = "D:\\C_SHARP_PROJECT\\data\\data.txt";

            string errorKey = "";

            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] pair = line.Split(':');
                        errorKey = pair[0];
                        data.Add(pair[0], pair[1]);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine(errorKey);
                }
            }
        }

        public string LookUpWord(string word)
        {
            try
            {
                return data[word];
            }catch(KeyNotFoundException)
            {
                return "Từ không tồn tại";
            }
        }
        
    }
}
