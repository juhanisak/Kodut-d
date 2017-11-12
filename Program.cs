using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc4
{
    class Program
    {
        static void Main(string[] args) // https://youtu.be/QwygwfqOHsI <--- videot kasutasin meetodite õppimiseks ja tegin programmi, mis kasutab meetodit, mis arvutab, vastvalt istumiskaugusele telekast, teleka suuruse tollides.
        {
            Console.WriteLine("Kui suure diagonaaliga(tollides) televiisorit vajad?");

            Console.WriteLine();

            Console.Write("Sisestage vaatamise kaugus meetrites: ");




            string input1 = Console.ReadLine();

            double kaugus = double.Parse(input1);




            Console.WriteLine("Vajad " + Diagonaal(kaugus) + " tollist televiisorit.");

            Console.ReadLine();

        }



        static double Diagonaal(double kaugus)
        {
            return kaugus * 100 * 0.39 / 2.5;
        }
    }
}
