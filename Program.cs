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
            Console.WriteLine("Mensaje 1");
            Console.ReadKey();
            Console.WriteLine("Mensaje 2");
            Console.ReadKey();
            Console.WriteLine("Ingrse un numero:");
            int numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrse un segundo numero:");
            int numeroB = int.Parse(Console.ReadLine());
            Console.WriteLine(numeroA+numeroB);
            Console.ReadKey();
        }
    }
}
