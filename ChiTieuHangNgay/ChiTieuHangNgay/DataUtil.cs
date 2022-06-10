using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace ChiTieuHangNgay
{
    class DataUtil
    {
        XmlElement root;
        XmlDocument doc;
        string filename;

        public DataUtil()
        {
            filename = "Data.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement rt = doc.CreateElement("chitieuhangngay");
                doc.AppendChild(rt);
                doc.Save(filename);
            }

            // tạo file nhật ký
            string path = "NhatKy.txt";
            FileStream filelog;
            if (!File.Exists(path))
            {
                filelog = new FileStream(path, FileMode.CreateNew);
                filelog.Close();
            }

            // tạo file cài đặt

            // tạo file tài khoản


            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public string ChiaThapPhan(string chuoi)
        {
            string result = "";
            int i = 0;

            if (chuoi.Length <= 3)
            {
                result = chuoi;
            }

            while (chuoi.Length > 3)
            {
                i = chuoi.Length - 3;
                result = "." + chuoi.Substring(i, 3) + result;
                chuoi = chuoi.Substring(0, i);

                if (chuoi.Length <= 3)
                {
                    result = chuoi + result;
                }
            }

            return result;
        }

        public string ConvertNumberToText(string chuoi)
        {
            string result = "";

            // vd: 152685
            int soluong = chuoi.Length;
            bool running = true;
            while(running)
            {
                if (soluong == 0)
                    break;

            }

            return result;
        }

        public string NumberToText(string chuoi, int soluong)
        {
            string result = "";

            if(soluong == 1)
            {
                if (int.Parse(chuoi) == 1)
                    result = "Một";
                if (int.Parse(chuoi) == 2)
                    result = "Hai";
                if (int.Parse(chuoi) == 3)
                    result = "Ba";
                if (int.Parse(chuoi) == 4)
                    result = "Bốn";
                if (int.Parse(chuoi) == 5)
                    result = "Năm";
                if (int.Parse(chuoi) == 6)
                    result = "Sáu";
                if (int.Parse(chuoi) == 7)
                    result = "Bảy";
                if (int.Parse(chuoi) == 8)
                    result = "Tám";
                if (int.Parse(chuoi) == 9)
                    result = "Chín";
            }    
            else if(soluong == 2)
            {

            }    
            else if(soluong == 3)
            {

            }    
            else if(soluong == 4)
            { }    
            else if(soluong == 5)
            { }    
            else if(soluong == 6)
            { }    
            else if(soluong == 7)
            { }    
            else if(soluong == 8)
            { }    

            return result;
        }


    }
}
