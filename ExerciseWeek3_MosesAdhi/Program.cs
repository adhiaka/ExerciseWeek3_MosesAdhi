using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_MosesAdhi
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;

            Hitung hitung = new Hitung();
            BangunDatar bangun = new BangunDatar();
            BangunDatar1 bangun1 = new BangunDatar1();

            Console.WriteLine("Hitung Luas dan Keliling");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Jajar genjang");
            Console.WriteLine("4. Lingkaran");
            Console.WriteLine("5. Segitiga Sama Sisi");
            Console.Write("Silahkan pilih salah satu : ");
            pilih = Convert.ToInt32(Console.ReadLine());


            switch (pilih)
            {
                case 1:
                    bangun.Bangun(hitung.s);
                    break;
                case 2:
                    bangun.Bangun(hitung.p, hitung.l);
                    break;
                case 3:
                    bangun.Bangun(hitung.aj, hitung.tj, hitung.m);
                    break;
                case 4:
                    bangun1.Bangun(hitung.r);
                    break;
                case 5:
                    bangun1.Bangun(hitung.a, hitung.t);
                    break;
            }


        }
    }
}
