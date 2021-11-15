using System;

namespace Tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
        // Implicit Conversion (Bilinçsiz Dönüşüm)

        Console.WriteLine("***** Implicit Conversion *****");

        byte a = 3;
        sbyte b = 6;
        short c = 20;

        int d = a+b+c;
        Console.WriteLine("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);

        string e = "hehehe";
        char f = 'y';
        object g = e+f+d;
        Console.WriteLine("g:" + g);

        // Explicit Conversion (Bilinçli Dönüşüm)

        Console.WriteLine("***** Explicit Conversion *****");

        int x = 2;
        byte y = (byte)x;
        Console.WriteLine("y:" +y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" +t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" +v);

        // ***** ToString Methodu *****

        Console.WriteLine("***** ToString Methodu *****");

        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" +yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" +zz);

        // System.Convert

        Console.WriteLine("***** System.Convert Sınıfı *****");
        string s1 = "10", s2 = "20";
        int sayı1, sayı2;
        int Toplam;

        sayı1 = Convert.ToInt32(s1);
        sayı2 = Convert.ToInt32(s2);

        Toplam = sayı1 + sayı2;
        Console.WriteLine("Toplam:" + Toplam);

        // Parse

         Console.WriteLine("***** Parse Methodu *****");
         ParseMethod();




        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,28";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);
            double ad = 3.3;
            Console.WriteLine(ad);

        }
    }
}
