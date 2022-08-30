using System;
using System.Globalization;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaRetangulo a = new AreaRetangulo();

            Console.WriteLine("Qual a Largura deste retangulo?");
            a.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a altura deste retangulo?");
            a.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(a);
        }
        
    }
}
