using System;

namespace INADevOps2
{
    public class Program
    {
        public string Transformado;
        public void Transformar(string h) { Transformado = h.ToUpper(); }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Console.Write("EScribe tu nombre ");
            string n = Console.ReadLine();
            p.Transformar(n);
            Console.WriteLine("El nombre tuyo es {0} ", p.Transformado);
        }
    }
}
