using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3Mendez
{
    class Program
    {
        static void Main(string[] args)
        {


            //Ejercicio1();
            //Ejercicio2("hola");
            //Ejercicio3();
            Ejercicio4();

        }

        static int Ejercicio1()
        {
            int numero = 0;
            string valor = "";
            Console.WriteLine("Escribe un número");
            valor = Console.ReadLine();
            do
            {
             
                     if (valor.Contains ("0") || valor.Contains ("1") || valor.Contains( "2") || valor.Contains( "3") || valor.Contains("4") || valor.Contains("5") || valor.Contains( "6") || valor.Contains( "7") || valor.Contains("8")|| valor.Contains( "9"))
                   
                    {
                        
                        numero = Convert.ToInt32(valor);
                        return numero;
                        
                    }
                    
                    else
                    {
                       Console.WriteLine("Error, ingrese nuevamente un número");
                        
                    }
                
            }
            while (valor == "" || valor != "");

            return 0;
           
        }

            static string Ejercicio2(string a)
        {
            string mensaje;
            mensaje = a;
            Console.WriteLine(" {0}", a);
            return mensaje;
        }


        static void Ejercicio3()
        {
           int a;
           a = Ejercicio1();
           string b;
          

            if (a > 10)
            {
                b = Ejercicio2("El número ingresado es mayor que 10 "); 
               
            }
            else
            {
                b = Ejercicio2("El número ingresado es menor que 10 ");
                
            }
        }
        static void Ejercicio4()
        {
            int a;
            a = Ejercicio1();
            string b;

            if (a % 5 == 0)
            {
                b = Ejercicio2("El número ingresado es divisible por 5");
            }
            else
            {

                b = Ejercicio2("El número ingresado no es divisible por 5");
            }
        }

    }
}      
