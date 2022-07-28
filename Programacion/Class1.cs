using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion
{
    internal class Class1   
    { 
        static void Main(string[] args)


        {   //1.punto
            string[] nombre;
            double[] parcial;
            double[] oral;
            double[] final;

            nombre = new string[4];
            parcial = new double[4];
            oral = new double[4];
            final = new double[4];

            for (int f = 0; f < nombre.Length; f++)
            {
                Console.WriteLine("Ingrese los siguientes datos");
                Console.WriteLine("nombre del estudiante");
                nombre[f] = Console.ReadLine();
                Console.WriteLine(" nota del examen parcial");
                parcial[f] = double.Parse(Console.ReadLine());
                Console.WriteLine(" nota del examen oral");
                oral[f] = double.Parse(Console.ReadLine());
                Console.WriteLine(" nota del examen final ");
                final[f] = double.Parse(Console.ReadLine());
                double promedio = (parcial[f] + oral[f] + final[f]) / 3;
                Console.WriteLine("promedio del estudiante fue: " + promedio);

                if (promedio >= 7)
                {
                    Console.WriteLine(nombre[f] + " Aprobado");
                }
                else
                {
                    Console.WriteLine(nombre[f] + " NoAprobado");
                }
                
            }




            //2.punto
            string[] nombres;
            string[] apellidos;
            int[] edad;
            string[] sexo;


            {
            nombres = new string[5];
            apellidos = new string[5];
            edad = new int[5];
            sexo = new string[5];

            for (int f = 0; f < nombres.Length; f++) 
            {
            Console.WriteLine("Escriba su nombre");
            nombres[f] = Console.ReadLine();
            }         

            for (int f = 0; f < apellidos.Length; f++)
            {
            Console.WriteLine("Escriba su apellido");
            apellidos[f] = Console.ReadLine();
            }


            for (int f = 0; f < edad.Length; f++)
            {
            Console.WriteLine("Digite su edad");
            edad[f] =int.Parse(Console.ReadLine());
            }


            for (int f = 0; f < sexo.Length; f++)
            {
            Console.WriteLine("Escriba su sexo");
            sexo[f] = Console.ReadLine();
            }
            }

            //3.punto


            string[] producto = new string[5];
            double[] precio = new double[5];

            Console.WriteLine("Ingrese los valores delos productos que nesesite");

            for (int f = 0; f < precio.Length; f++)
            {
            Console.WriteLine("ingrese el nombre del {0}  producto",f+1);
            producto[f] = Console.ReadLine();
            Console.WriteLine("ingrese el precio del {0}  producto",f+1);
            precio[f] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("El total es de "+ precio.Sum());
            Console.ReadKey();
        }
        
        
    }
}
