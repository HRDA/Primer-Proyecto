using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            attemp1();
        }

        static void attemp1()
        {
            Console.Title = "Registro de clientes";
            string[] name = new string[5];
            string[] model = new string[5];
            int[] visit = new int[5];
            double[] cost = new double[5];
            double[] descount = new double[5];
            int[] dui = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el nombre del cliente número " + (i + 1));
                name[i] = Console.ReadLine();
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t" + name[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el numero de Dui del cliente número " + (i + 1));
                dui[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t" + dui[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el modelo de vehiculo del cliente número " + (i + 1));
                model[i] = Console.ReadLine();
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t" + model[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el costo de reparacion para el cliente " + (i + 1));
                cost[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t" + cost[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el número de visitas del cliente número " + (i + 1));
                visit[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t" + visit[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                if (visit[i] >= 2 && visit[i] <= 9)
                {
                    descount[i] = cost[i] * 0.05;
                }
                if (visit[i] >= 10)
                {
                    descount[i] = cost[i] * 0.10;
                }
                else
                {
                    descount[i] = cost[i];
                }




            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("El cliente con nombre: " + name[i] + " y con un modelo de vehiculo " + model[i] + " tiene un costo de reparacion inicial de " + cost[i] +
                    " y al revisar su número de visitas su precio de reparacion es " + descount[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("¿Desea buscar a un cliente por su número de Dui?");
            Console.WriteLine("\n1. Si");
            Console.WriteLine("\n2. No");
            Console.WriteLine("\n");
            int opcion;
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)

            {

                Console.Title = "Búsqueda por número de Dui";



                int search, found, result;

                Console.WriteLine("\n");

                Console.WriteLine("Digite el Dui del usuario a buscar");


                found = 1; result = 0;

                search = int.Parse(Console.ReadLine());
                for (i = 0; i <= 4; i++)

                {
                    if (search == dui[i])
                        result = 1;
                }



                if (found == result)
                {
                    Console.WriteLine("El dui: " + search + " fue encontrado");


                }


                if (search == dui[0])

                {
                    Console.WriteLine("El cliente es: " + name[0]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + model[0]);
                    Console.WriteLine("\nSu costo de reparación es de: " + cost[0]);
                    Console.WriteLine("\nSu número de visitas es: " + visit[0]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + descount[0]);
                   


                }

                else if (search == dui[1])

                {
                    Console.WriteLine("El cliente es: " + name[1]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + model[1]);
                    Console.WriteLine("\nSu costo de reparación es de: " + cost[1]);
                    Console.WriteLine("\nSu número de visitas es: " + visit[1]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + descount[1]);
                }
                else if (search == dui[2])

                {
                    Console.WriteLine("El cliente es: " + name[2]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + model[2]);
                    Console.WriteLine("\nSu costo de reparación es de: " + cost[2]);
                    Console.WriteLine("\nSu número de visitas es: " + visit[2]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + descount[1]);

                }
                else if (search == dui[3])

                {
                    Console.WriteLine("El cliente es: " + name[3]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + model[3]);
                    Console.WriteLine("\nSu costo de reparación es de: " + cost[3]);
                    Console.WriteLine("\nSu número de visitas es: " + visit[3]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + descount[3]);

                }
                else if (search == dui[4])

                {
                    Console.WriteLine("El cliente es: " + name[4]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + model[4]);
                    Console.WriteLine("\nSu costo de reparación es de: " + cost[4]);
                    Console.WriteLine("\nSu número de visitas es: " + visit[4]);
                    Console.WriteLine("\nEl modelo de su vehículo es: " + descount[4]);

                }


                else if (found != result)
                    Console.WriteLine("El número {0} no fue encontrado", search);
                Console.WriteLine("\n");
                Console.ReadKey();
            }

            else

            {
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
    