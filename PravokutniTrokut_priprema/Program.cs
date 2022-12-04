using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PravokutniTrokut_priprema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            try 
            {
                while (true)
                {
                    Console.WriteLine("unesite stranicu a:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("unesite stranicu b:");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("unesite stranicu c:");
                    z = Convert.ToInt32(Console.ReadLine());

                    if(x==0 || y==0 || z==0)
                    {
                        Console.WriteLine("sve stranice moraju biti vece od 0.");
                        break;
                    }

                    if (Math.Pow(x, 2) + Math.Pow(y, 2) != Math.Pow(z, 2))
                    {
                        Console.WriteLine("unesene stranice ne cine pravokutni trokut.");
                        break;
                    }
                }
            }
            catch(Exception greska)
            {
                Console.WriteLine("Neispravan Unos, pokušaj ponovo.");
                Console.Write("Opis greške: " + greska.Message);
            }

            Console.ReadKey();
        }
    }
}
