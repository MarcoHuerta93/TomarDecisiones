﻿using System;

namespace TomarDecisiones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //if anidados

            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            Console.WriteLine("Por favor ingrese su nombre de usuario");

            nombreDeUsuario = Console.ReadLine();

            if (estaRegistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin"))
            {
                Console.WriteLine("Hola Usuario registrado");
                    Console.WriteLine("Hola " + nombreDeUsuario);
                        Console.WriteLine("Hola Admin");
                    
                }
            if(esAdmin || estaRegistrado)
            {
                Console.WriteLine("Estás loguado");
            }
            

            //TRYPARSE

            /* string temperatura = Console.ReadLine();

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
             Console.Read();*/
            Console.Read();
        }
    }
}
