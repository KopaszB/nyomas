using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nyomas
{
    internal class Program
    {
        static List<int> adatok = new List<int>();
        static void Main(string[] args)
        {
            adatBeolvas();
            
            //2.feladat
            int min = adatok.Min();
            int minIndex = adatok.FindIndex(x => x == min);
            Console.WriteLine($"A legkisebb mért érték: {min}");
            Console.WriteLine($"A legkisebb mérési adat sorszáma: {minIndex+1}");

            Console.ReadKey();
        }

        private static void adatBeolvas()
        {
            using (StreamReader olvas = new StreamReader("nyomas.txt"))
            {
                string[] sor = olvas.ReadLine().Trim().Split(',');
                for (int i = 0; i < sor.Length; i++)
                {
                    int listaelem = int.Parse(sor[i]);
                    adatok.Add(listaelem);  
                }
            }
        }
    }
}
