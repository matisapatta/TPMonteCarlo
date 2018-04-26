using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMonteCarlo
{
    class Program
    {

        static void Main(string[] args)
        {

            void Integral()
            {
                double n;
                double n1 = 0;
                double x;
                double y;
                double area;
                Random random = new Random();
                Console.Write("Ingrese cantidad de números aleatorios: ");
                double.TryParse(Console.ReadLine(), out n);
                for (int i = 0; i < n;i++){
                    x = random.NextDouble();
                    y = random.NextDouble();
                    if (y < Math.Pow(x, 2))
                    {
                        n1++;
                    }
                }
                area = n1 / n;
                Console.WriteLine("El área es: " + area);


            }
            void Pi()
            {
                double n;
                Console.Write("Ingrese cantidad de números aleatorios: ");
                double.TryParse(Console.ReadLine(), out n);
                double x = 0;
                Random randgen = new Random();

                for (int i = 0; i < n; i++)
                {
                    double randx = randgen.NextDouble();
                    double randy = randgen.NextDouble();
                    double h = Math.Sqrt(Math.Pow(randx, 2) + Math.Pow(randy, 2));
                    if (h < 1)
                        x++;
                }

                double pi = 4 * x / n;

                Console.WriteLine(pi);

            }

            void Agujas()
            {
                int l = 10;
                int d = 12;
                double contador = 0;
                double tita = 0;
                double a = 0;
                double p = 0;
                Random random = new Random();
                double randtita;
                double randa;
                double n;
                Console.Write("Ingrese cantidad de números aleatorios: ");
                double.TryParse(Console.ReadLine(), out n);

                for (int i = 0; i < n; i++)
                {
                    randa = random.NextDouble();
                    randtita = random.NextDouble();
                    tita = Math.PI * randtita;
                    a = (d / 2) * randa;
                    if (a <= ((l / 2) * Math.Sin(tita)))
                    {
                        contador++;
                    }
                }
                p = contador / n;
                double pi = (2 * l) / (p * d);
                Console.WriteLine(pi);



            }
            int selector;
            Console.WriteLine("Menu:");
            Console.WriteLine("1-Simulación área bajo la curva");
            Console.WriteLine("2-Número Pi");
            Console.WriteLine("3-Agujas de Buffon");
            int.TryParse(Console.ReadLine(), out selector);
            switch (selector)
            {
                case 1:
                    Integral();
                    break;
                case 2:
                    Pi();
                    break;
                case 3:
                    Agujas();
                    break;
                default:
                    Console.WriteLine("Por defecto, es la simulación del número Pi");
                    Pi();
                    break;
            }
            Console.ReadKey();

        }
    }
}
