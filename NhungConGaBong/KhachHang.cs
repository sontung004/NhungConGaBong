using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoDemKH { get; set; }
        public string TenKH { get; set; }
        public string MaSoThue {  get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string STK {  get; set; }
        public int NganHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public  KhachHang() 
        {
            NganHangID = 0;
            MaKH = HoDemKH = TenKH = MaSoThue = DienThoai = Email = STK = "";
        }
        public KhachHang this[List<KhachHang> khList, int index]
        {
            get
            {
                if (0 > index || index >= khList.Count)
                {
                    throw new IndexOutOfRangeException("Index not valid!!!");
                    //return null;
                }
                else return khList[index];
            }
            set
            {
                if (index > 0 || index >= khList.Count)
                    throw new IndexOutOfRangeException("Index not valid!!!");
                else
                    khList[index] = value;
            }
        }

        public KhachHang(string ckhLine)
        {
            string[] values = ckhLine.Split(',');
            this.MaKH = values[0];
            this.HoDemKH = values[1];
            this.TenKH = values[2];
            this.MaSoThue = values[3];
            this.DienThoai = values[4];
            this.Email = values[5];
            this.STK = values[6];
            this.NganHangID = Convert.ToInt32(values[7]);
            var cultureInfoVietName = new CultureInfo("vi-VN");
            string dateString = values[8];
            var date1 = DateTime.ParseExact(dateString, "dd/MM/yyyy", cultureInfoVietName);
            this.NgayLap = date1;
        }

        public static int SaveToFile(List<KhachHang> khList, string fileName, bool insert = false)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, append: insert);
                if (!insert)
                {
                    string header = "MaKH,HoDem,TenKH,DienThoai,Email,MaSoThue,STK,NganHangID,NgayLap";
                    //Headers                  
                    sw.Write(header);
                    sw.Write(sw.NewLine);
                }
                // Lines
                foreach (var kh in khList)
                {
                    string line = "";
                    line += "," + kh.MaKH;
                    line += "," + kh.HoDemKH;
                    line += "," + kh.TenKH;
                    line += "," + kh.DienThoai;
                    line += "," + kh.Email;
                    line += "," + kh.MaSoThue;
                    line += "," + kh.STK;
                    line += "," + kh.NganHangID;
                    line += "," + kh.NgayLap.ToString("dd/MM/yyyy");
              
                    line = line.Remove(0, 1);
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

        public static List<KhachHang> ReadFromFile(string fileName)
        {
            List<KhachHang> list = new List<KhachHang>();
            string line = "";
            using (StreamReader reader = new StreamReader(fileName))
            {

                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    KhachHang kh = new KhachHang(line);

                    // Add KhachHang to List
                    list.Add(kh);
                }
            }
            return list;
        }

        public static DataTable ToDataTable(List<KhachHang> khList)
        {
            DataTable dataTable = new DataTable();
            string[] headers = { "MaKH", "TenKH", "DienThoai", "IDNhanVien" };
            for (int i = 0; i < headers.Length; i++)
            {
                dataTable.Columns.Add(headers[i]);
            }
            foreach (var item in khList)
            {
                DataRow row;
                row = dataTable.NewRow();
                row[0] = item.MaKH;
                row[1] = item.HoDemKH;
                row[2] = item.TenKH;
                row[3] = item.DienThoai;
                row[4] = item.Email;
                row[5] = item.MaSoThue;
                row[6] = item.STK;
                row[7] = item.NganHangID;
                row[9] = item.NgayLap;
                dataTable.Rows.Add(row);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        public static List<T> Sort<T>(List<T> input, string property, SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
            {
                return input.OrderByDescending(p => p.GetType().GetProperty(property).GetValue(p, null)).ToList();
            }
            else
            {
                return input.OrderBy(p => p.GetType().GetProperty(property).GetValue(p, null)).ToList();
            }
        }

    }
}

