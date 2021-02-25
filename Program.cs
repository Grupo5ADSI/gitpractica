using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("msn 1");
            Console.ReadKey();
            Console.WriteLine("msn 2");
            Console.ReadKey();
            Console.WriteLine("Ingrese un numero:");
            int numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero:");
            int numeroB = int.Parse(Console.ReadLine());
            Console.WriteLine("la resta de "+numeroA+" + "+numeroB+" = "+(numeroA-numeroB));
            Console.ReadKey();
        }
    }
}
