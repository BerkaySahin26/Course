using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add();
            int b = 10;
            int c = 15;
            var sonuc = topla(ref b, out c);
            var sonuc2 = bol(15, 3);
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.WriteLine(multiply(1, 2, 3));
            Console.WriteLine(param(1, 2, 3, 4, 5, 6, 7, 8)); // belli bir sayısı yok 
            Console.ReadLine();
        }

        static void add()
        {
            Console.WriteLine("Selam");
        }

        static int topla(ref int b, out int c)
        {
            b = 12;/// ref ile metot içerisinde dışardan girilen sayı hakkında değişiklik yaptık
            c = 11; // out ile dışarıdan veri versek bile içeride değişim ister
            var toplama = b + c;
            return toplama;
        }

        static int bol(int b, int c)
        {
            var bolme = b / c;
            return bolme;
        }

        /// default
        static int def(int x, int y = 20) // default kısımda sağdaki tekli değerlerde alabilirken soldaki alamaz, ya ikisine yada sağdan başlayacak şekilde verilmeli
        {
            var d = x + y;
            return d;
        }
        static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int param(int number, params int[] para) // param kısmı dizisi belli bir sınır olmadan alır param son parametre olmalı
        {                                                // Öncesine attığımız number diziye dahil olmaz bu sebepten işlemde yok
            return para.Sum();
        }

    }
}
