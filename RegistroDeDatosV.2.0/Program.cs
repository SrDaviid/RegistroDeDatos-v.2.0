using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace RegistroDeDatosV._1._0
{
    class Program
    {
        private const int V = 2;

        static void Main(string[] args)
        {

        string filename = "filename.csv";

        using (StreamWriter sw = File.AppendText(filename))
        {
            sw.WriteLine("ID, Name, Last Name, Age");

            Console.WriteLine("Cual es tu cedula?");
            int cedula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cual es tu nombre?");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Cual es tu apellido?");
            string apellido = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Cual es tu edad?");
            int edad = Convert.ToInt32(Console.ReadLine());

            sw.WriteLine(+ cedula +" , "+ nombre +" , "+ apellido +" , "+ edad);

            Console.WriteLine("Seleccione la opcion que desee");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Seguir listando");
            Console.WriteLine("2. Salir");
            int op;
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("Cual es tu cedula?");
                int ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cual es tu nombre?");
                string Name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cual es tu apellido?");
                 string LastName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cual es tu edad?");
                int Age = Convert.ToInt32(Console.ReadLine());

                 sw.WriteLine(+ cedula +" , "+ nombre +" , "+ apellido +" , "+ edad);
                 break;

                 case 2:
                 default:
                 Console.Clear();
                 Console.WriteLine("Programa Cerrado");
                 break;



            }

        




        }

            

     
               
        }
       
    }
}
