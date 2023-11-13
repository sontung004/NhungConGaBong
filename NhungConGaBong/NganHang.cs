using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class NganHang
    {
        public int ID {  get; set; }
        public string TenNH { get; set; } = null!;
        public string MaNH { get; set; } = null!;
        public string TenGD { get; set; } = null!;
        public DateTime NgayLap { get; set; }
        public DateTime NgaySua { get; set; }
        
        public NganHang() { }
        public NganHang(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.ID = Convert.ToInt32(values[0]);
            this.MaNH = values[1];
            this.TenNH = values[2];
            this.TenGD = values[3];
            var cultureInfoVietName = new CultureInfo("vi-VN");

            string dateString = values[4];
            var date1 = DateTime.ParseExact(dateString, "dd/MM/yyyy", cultureInfoVietName);
            this.NgayLap = date1;

            dateString = values[5];
            var date2 = DateTime.ParseExact(dateString, "dd/MM/yyyy", cultureInfoVietName);
            this.NgaySua = Convert.ToDateTime(date2);
        }

        public static List<NganHang> ReadFromFile(string fileName)
        {
            List<NganHang> list = new List<NganHang>();
            string line = "";
            using (StreamReader reader = new StreamReader(fileName))
            {               
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    NganHang d = new NganHang(line);
                    list.Add(d);
                }
            }
            return list;
        }
        public static int SaveToFile(List<NganHang> ngList, string fileName, bool insert = false)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, append: insert);
                string header = "ID,MaNH,TenNH,TenGD,NgayLap,NgaySua";
                //Headers                  
                sw.Write(header);
                sw.Write(sw.NewLine);
                // Lines
                foreach (var ng in ngList)
                {
                    string line = ng.ID.ToString();
                    line += "," + ng.MaNH;
                    line += "," + ng.TenNH;
                    line += "," + ng.TenGD;
                    line += "," + ng.NgayLap.ToString("dd/MM/yyyy");
                    line += "," + ng.NgaySua.ToString("dd/MM/yyyy");
                    //line = line.Remove(0, 1);
                    sw.Write(line);
                    sw.Write(sw.NewLine);
                }
                sw.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
