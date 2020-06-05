using System;

namespace Projeto_Thiago_Lima
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new ClasseA();
            var b1 = new ClasseB();
            a1.MA1();
            a1.MA2();
            b1.MB1();
            b1.MB2();
            Console.WriteLine("Sucesso!");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
