using System;

namespace EjemploGrupo2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                
            {

                Console.WriteLine("Hola Bienvenido Ingrese Su Nombre ");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Hola Ingrese Su Edad");
                int Edad = Convert.ToInt32(Console.ReadLine());            
                Console.WriteLine("Hola Ingrese su Sexo: M..Maculino: F..Femenino:");
                string Sexo = Console.ReadLine();
                if (Sexo == "M" || Sexo == "m")
                    Console.WriteLine("El Sr.{0} ha sido registrado", Nombre);
                else if (Sexo == "F" || Sexo == "f")
                    Console.WriteLine("La Sra. {0} ha sido regisrada", Nombre, Sexo);
                else
                    Console.WriteLine("La Sra.{0} ha sido registrada", Nombre, Sexo);
                Console.ReadLine();

 
           
 
            }


        }

    }

}

