using System;
namespace SUDUNGPHUONGTHU
{
    class TimGiaTriNhoNhatMang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu mang:");
            int sophantu = Convert.ToInt32(Console.ReadLine());
            int[] mangnhapvao = new int[sophantu];
            Console.WriteLine("Nhap cac phan tu:");
            for(int chiso = 0; chiso < sophantu; chiso++)
            {
                mangnhapvao[chiso] = Convert.ToInt32(Console.ReadLine());
            }
            int vitriphantu = MinValue(mangnhapvao);
            Console.WriteLine($"Phan tu nho nhat cua mang la: {mangnhapvao[vitriphantu]}");
        }
        public static int MinValue(int [] mang)
        {
            int giatrinhonhat = mang[0];
            int chisonhonhat = 0;
            for(int chiso=1; chiso < mang.Length; chiso++)
            {
                if (mang[chiso]<giatrinhonhat)
                {
                    giatrinhonhat = mang[chiso];
                    chisonhonhat = chiso;
                }
            }
            return chisonhonhat;
        }
    }
}