using System;

namespace TomarDecisiones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string temperatura = Console.ReadLine();

            int numTemperatura;

            int numero;
            if (int.TryParse(temperatura, out numero)) {

                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("El valor ingresado no es válido, se estableció que la temperatura es 0" +
                    "");
            }

            if (numTemperatura < 20)
            {
                Console.WriteLine("Abrígate");

            }
            else if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo!!");
            }
           else if (numTemperatura > 30)
            {
                Console.WriteLine("Hacen 30 grados, que calor!!");
            }
            else 
            {
                Console.WriteLine("Usa ropa bien liviana!!");
            }
            Console.Read();
        }
    }
}
