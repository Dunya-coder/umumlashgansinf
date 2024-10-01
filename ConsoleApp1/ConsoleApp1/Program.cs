using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //umumlashgan sinf oddiy sinflar ichida ham umumlashgan metod elon qilish mumkin
            /*    double[] a = { 9, 5, 1, 8, 3, 1 };*/
            //2-float
            float[] x = new float[] { 2.1f, -3.5f, 5.6f };
            x.Max();
            Massiv<float> aa = new Massiv<float>(x);
            Console.WriteLine($"sum-{aa.Sum()}");
            Console.WriteLine("2-umumlashgan sinf");
            Massiv<long> a1 = new Massiv<long>
                (new long[] { 2100l, 500l, 76l });
            a1.Max();
        }
        static void aa<T>(T a, T b)//ixtiyoriy tur uchun ishlaydigan metod yuza
        {
            double s;
            s = Convert.ToDouble(a) * Convert.ToDouble(b);//har bir T qiymatli qiymatni double ga o'tkazish shart
            Console.WriteLine($"yuza-{s}");
        }
    }
    class Massiv<T>
    {
        T[] a;//ixtiyoriy turdagi massiv elon qilish
              // private T a, h;//shu sinfga bogliq bo'lsa T yoziladi yani turi,bir
        public Massiv(T[] x)
        {
            int n = x.Length;

            a = new T[n];
            a = x;

        }
        public double Sum()
        {
            double s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += Convert.ToDouble(a[i]);//massiv ixtiyoriy son turida
            }
            return s;
        }
        public void Max()
        {
            double m = Convert.ToDouble(a[0]);
            for (int i = 0; i < a.Length; i++)
            {
                if (Convert.ToDouble(a[i]) > m)
                {
                    m = Convert.ToDouble(a[i]);

                }
            }
            Console.WriteLine($"Massivdan Max-{m}");
        }


    }
}
