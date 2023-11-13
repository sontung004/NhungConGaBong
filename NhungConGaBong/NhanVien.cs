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
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoDem { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }    
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public NhanVien()
        {
            
        }
        public NhanVien this[List<NhanVien> nvList, int index]
        {

            get
            {
                if (0 > index || index >= nvList.Count)
                {
                    throw new IndexOutOfRangeException("Index not valid!!!");
                    //return null;
                }
                else return nvList[index];
            }
            set
            {
                if (index > 0 || index >= nvList.Count)
                    throw new IndexOutOfRangeException("Index not valid!!!");
                else
                    nvList[index] = value;
            }
        }

        public NhanVien(string cnvLine)
        {
            // đổi chuỗi ra mảng thông qua kí tự dấu phẩy ','
            string[] values = cnvLine.Split(',');
            this.MaNV = values[0];
            this.HoDem = values[1];
            this.Ten = values[2];

            var cultureInfoVietName = new CultureInfo("vi-VN");

            string dateString = values[3];
            this.NgaySinh = DateTime.ParseExact(dateString, "dd/MM/yyyy", cultureInfoVietName);

            this.GioiTinh = values[4];
            this.DiaChi = values[5];
            this.SDT = values[6];
        }

        public static int SaveToFile(List<NhanVien> nvList, string fileName, bool insert = false)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, append: insert))
                {
                    if (!insert)
                    {
                        sw.WriteLine("MaNV,HoDem,Ten,NgaySinh,GioiTinh,DiaChi,SDT"); // Viết tiêu đề chỉ một lần
                    }

                    foreach (var nv in nvList)
                    {
                        string line = "";
                        line += "," + nv.MaNV;
                        line += "," + nv.HoDem;
                        line += "," + nv.Ten;
                        line += "," + nv.NgaySinh.ToString("dd/MM/yyyy");
                        line += "," + nv.GioiTinh;
                        line += "," + nv.DiaChi;
                        line += "," + nv.SDT;
                        line = line.Remove(0, 1);
                        sw.Write(line);
                        sw.Write(sw.NewLine);
                    }
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static List<NhanVien> ReadFromFile(string fileName)
        {
            List<NhanVien> list = new List<NhanVien>();
            string line = "";
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    NhanVien nv = new NhanVien(line);

                    // Add NhanVien to List
                    list.Add(nv);
                }
            }
            return list;
        }

        public static DataTable ToDataTable(List<NhanVien> nvList)
        {
            DataTable dataTable = new DataTable();
            string[] headers = { "MaNV", "HoDem", "Ten", "NgaySinh", "GioiTinh", "DiaChi", "SDT" };
            for (int i = 0; i < headers.Length; i++)
            {
                dataTable.Columns.Add(headers[i]);
            }
            foreach (var item in nvList)
            {
                DataRow row;
                row = dataTable.NewRow();
                row[0] = item.MaNV;
                row[1] = item.HoDem;
                row[2] = item.Ten;
                row[3] = item.NgaySinh;
                row[4] = item.GioiTinh;
                row[5] = item.DiaChi;
                row[6] = item.SDT;
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
