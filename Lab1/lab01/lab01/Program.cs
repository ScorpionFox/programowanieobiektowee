using System;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Ulamek
    {
        private int licznik;
        private int mianownik;

        public class KonstruktorDomyslny
        {
        }
        public class KonstruktorArgumentowy(int a, int b)
        {
          
        }
    public class KonstruktorKopiujacy
    {
        private int wiek;

        public KonstruktorKopiujacy( int wiek)
        {
            this.wiek = wiek;
        }

        public KonstruktorKopiujacy(KonstruktorKopiujacy konstrukt)
        {
            this.wiek = konstrukt.wiek;
        }
    }




    }
}
