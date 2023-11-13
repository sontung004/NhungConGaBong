using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class HopDong
    {
        public string MaHD { get; set; } = null!;
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string TenHD { get; set; }
        public string LoaiDat { get; set; }
        public int SoTo { get; set; }
        public int SoThua { get; set; }
        public string DienTich { get; set; }
        public string TriGia { get; set; }
        public DateTime NgayLap { get; set; }
        // số tờ và số thửa
        public HopDong()
        {


        }

        public HopDong this[List<HopDong> hdList, int index]
        {

            get
            {
                if (0 > index || index >= hdList.Count)
                {
                    throw new IndexOutOfRangeException("Index not valid!!!");
                    //return null;
                }
                else return hdList[index];
            }
            set
            {
                if (index > 0 || index >= hdList.Count)
                    throw new IndexOutOfRangeException("Index not valid!!!");
                else
                    hdList[index] = value;
            }
        }

        public HopDong(string chdLine)
        {
            // đổi chuỗi ra mảng thông qua kí tự dấu phẩy ','
            string[] values = chdLine.Split(',');
            this.MaHD = values[0];
            this.MaNV = values[1];
            this.MaKH = values[2];
            this.TenHD = values[3];
            this.LoaiDat = values[4];
            this.SoTo = Convert.ToInt32(values[5]);
            this.SoThua = Convert.ToInt32(values[6]);
            this.DienTich = values[7];
            this.TriGia = values[8];
            var cultureInfoVietName = new CultureInfo("vi-VN");

            string dateString = values[9];
            this.NgayLap = DateTime.ParseExact(dateString, "d/M/yyyy", cultureInfoVietName);
        }

        public static int SaveToFile(List<HopDong> hdList, string fileName, bool insert = false)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, append: insert);
                if (!insert)
                {
                    string header = "MaHD,MaNV,MaKH,TenHD,LoaiDat,SoTo,SoThua,DienTich,TriGia,NgayLap";
                    //Headers                  
                    sw.Write(header);
                    sw.Write(sw.NewLine);
                }
                // Lines
                foreach (var hd in hdList)
                {
                    string line = "";
                    line += "," + hd.MaHD;
                    line += "," + hd.MaNV;
                    line += "," + hd.MaKH;
                    line += "," + hd.TenHD;
                    line += "," + hd.LoaiDat;
                    line += "," + hd.SoTo;
                    line += "," + hd.SoThua;
                    line += "," + hd.DienTich;
                    line += "," + hd.TriGia;
                    line += "," + hd.NgayLap.ToString("d/M/yyyy");


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

        public static List<HopDong> ReadFromFile(string fileName)
        {
            List<HopDong> list = new List<HopDong>();
            string line = "";
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    HopDong hd = new HopDong(line);

                    // Add HopDong to List
                    list.Add(hd);
                }
            }
            return list;
        }

        public static DataTable ToDataTable(List<HopDong> hdList)
        {
            DataTable dataTable = new DataTable();
            string[] headers = { "Mahd", "TenCT", "DienThoai", "IDNhanVien" };
            for (int i = 0; i < headers.Length; i++)
            {
                dataTable.Columns.Add(headers[i]);
            }
            foreach (var item in hdList)
            {
                DataRow row;
                row = dataTable.NewRow();
                row[0] = item.MaHD;
                row[1] = item.MaNV;
                row[2] = item.MaKH;
                row[3] = item.TenHD;
                row[4] = item.LoaiDat;
                row[5] = item.SoTo;
                row[6] = item.SoThua;
                row[7] = item.DienTich;
                row[8] = item.TriGia;
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
