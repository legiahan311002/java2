using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chayT
{
    internal class Program
    {
        struct SinhVien
        {
            public double MaSV;
            public string Hoten;
            public double DiemToan;
            public double DiemLy;
            public double DiemHoa;
        }

        static void NhapThongTin(out SinhVien SV)
        {
            Console.Write("MaSo : ");
            SV.MaSV = System.Double.Parse(Console.ReadLine());
            Console.Write("Ho Ten : ");
            SV.Hoten = Console.ReadLine();
            Console.Write("Diem Toan = ");
            SV.DiemToan = System.Double.Parse(Console.ReadLine());
            Console.Write("Diem Ly = ");
            SV.DiemLy = System.Double.Parse(Console.ReadLine());
            Console.Write("Diem Hoa = ");
            SV.DiemHoa = System.Double.Parse(Console.ReadLine());

        }
        static void XuatThongTin(SinhVien SV)
        {
            Console.WriteLine("MaSV : " + SV.MaSV);
            Console.WriteLine("Hoten : " + SV.Hoten);
            Console.WriteLine("DiemToan = " + SV.DiemToan);
            Console.WriteLine("DiemLy = " + SV.DiemLy);
            Console.WriteLine("DiemHoa = " + SV.DiemHoa);
        }
        static double DTB(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemHoa) / 3;
        }
        

        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            Console.WriteLine("Nhap thong tin sinh vien : ");
            NhapThongTin(out SV1);
            Console.WriteLine("--------------");
            Console.WriteLine("thong tin sinh vien vua nhap ");
            XuatThongTin(SV1);
            Console.WriteLine("Diem trung binh = " + DTB(SV1));
            Console.ReadKey();

        }
        


    }
}
