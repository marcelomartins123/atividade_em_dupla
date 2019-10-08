using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 
        public static int diferenca(int m, int d)
        {
            m = m - d;
            return m;
        }
        static void Main(string[] args)
        {
            int n,h;
            Console.Write("digite um valor: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("digite outro valor: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("resultado é: "+diferenca(n,h));
            Console.Readtube();
        }
    }
}
