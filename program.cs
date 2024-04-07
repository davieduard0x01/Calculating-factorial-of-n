using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            double resultado = 1;
            Console.WriteLine("Digite o número");
            int num = int.Parse(Console.ReadLine());
            while (num !=1)
            {
                resultado = resultado * num;
                num -= 1;
               


            }
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}
