using System;

namespace not_ort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.notunuzu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());

            int ikinci_not = Convert.ToInt32(Console.ReadLine());

            int  ucuncu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("Not degeriniz: A+");
                Console.ReadLine();
            }
            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("Not degeriniz: A");
                Console.ReadLine();
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not degeriniz: B");
                Console.ReadLine();

            }
            else 
            {
                Console.WriteLine("F ile dersten kaldiniz");
                Console.ReadLine();
            }
        }

    }
}
