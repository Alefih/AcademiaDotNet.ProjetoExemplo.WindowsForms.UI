using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ConsoleApplication.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> nomes = new List<String>();

            nomes.Add("Alef");
            nomes.Add("Pele");
            nomes.Add("Kaka");
            nomes.Add("Zidane");
            nomes.Add("Kroos");
            nomes.Add("Iniesta");
            nomes.Add("Gabigol");
            nomes.Add("Messi");
            nomes.Add("Cristiano Ronaldo");
            nomes.Add("Neymar");
            nomes.Add("Messi");

            nomes.Sort();

            foreach (String nome in nomes)
            {
                Console.WriteLine($"Melhores Jogadores {nome.ToUpper()}!");
            }
            




        }
    }
}
