using System;

namespace TomarDecisiones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string temperatura = Console.ReadLine();

            int numTemperatura = int.Parse(temperatura);

            if (numTemperatura < 20)
            {
                Console.WriteLine("Abrígate");

            }
            if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo");
            }
            if (numTemperatura > 20)
            {
                Console.WriteLine("Usa ropa bien liviana!!");
            }
            Console.Read();
        }
    }
}
