using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SarkiSözü();
            SayiIkiBolumu();
            int result2 = Carpma(5, 3);
            Console.WriteLine(result2);
            Name("Osman", "Özyaşar");
        }

        public static void SarkiSözü()
        {
            Console.WriteLine("Du, Du Hast, Du Hast Mich");
        }

        public static int SayiIkiBolumu()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);           
            int result1 = randomNumber / 2;
            Console.WriteLine($"{randomNumber} sayısının 2 ye bölümü: {result1}");
            return result1;
        }

        public static int Carpma(int a, int b)
        {
            
            return a * b;
        }

        public static void Name(string firstName, string lastName)
        {
            Console.WriteLine($"Hoşgeldiniz {firstName} {lastName}");
        }
    }
}