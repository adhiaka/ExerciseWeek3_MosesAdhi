using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_MosesAdhi
{
    class Hitung
    {
        public double s, p, l, r, a, t, m, aj, tj, L1, K1;

    }

    class BangunDatar : Hitung
    {
        public void Bangun(double s)
        {
            try
            {
                Console.Write("Masukan sisi : ");
                s = double.Parse(Console.ReadLine());
                L1 = s * s;
                K1 = 4 * s;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Persegi = " + L1);
                Console.WriteLine();
                Console.Write("Keliling Persegi = " + K1);
                Console.ReadLine();
            }
        }

        public void Bangun(double p, double l)
        {
            try
            {
                Console.Write("Masukan panjang: ");
                p = double.Parse(Console.ReadLine());
                Console.Write("Masukan lebar : ");
                l = double.Parse(Console.ReadLine());
                L1 = p * l;
                K1 = 2 * (p + l);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Persegi Panjang = " + L1);
                Console.WriteLine();
                Console.Write("Keliling Persegi Panjang = " + K1);
                Console.ReadLine();
            }
        }

        public void Bangun(double aj, double tj, double m)
        {
            try
            {
                Console.Write("Masukan alas : ");
                aj = double.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi : ");
                tj = double.Parse(Console.ReadLine());
                Console.Write("Masukan sisi miring : ");
                m = double.Parse(Console.ReadLine());
                L1 = aj * tj;
                K1 = 2 * (aj + m);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Jajar genjang = " + L1);
                Console.WriteLine();
                Console.Write("Keliling Jajar genjang = " + K1);
                Console.ReadLine();
            }
        }



    }

    class BangunDatar1 : Hitung
    {
        public void Bangun(double r)
        {
            try
            {
                Console.Write("Masukan jari - jari : ");
                r = double.Parse(Console.ReadLine());
                L1 = 3.14 * r;
                K1 = 3.14 * (r * 2);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Lingkaran = " + L1);
                Console.WriteLine();
                Console.Write("Keliling Lingkaran = " + K1);
                Console.ReadLine();
            }
        }

        public void Bangun(double a, double t)
        {
            try
            {
                Console.Write("Masukan alas : ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi : ");
                t = double.Parse(Console.ReadLine());
                L1 = a * t;
                K1 = a + a + a;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Segitiga Sama Sisi= " + L1);
                Console.WriteLine();
                Console.Write("Keliling Segitiga Sama Sisi= " + K1);
                Console.ReadLine();
            }
        }





    }


}

