using System;

namespace _03.areatringulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, b, a;
            Console.WriteLine("Program que calcula el area de un triangulo");

            Console.WriteLine(args.Length);
            if(args.Length<2){
                Console.WriteLine("Forma de uso \n");
                Console.WriteLine("Debes pasar los parametros <base> y <altura>");
                Environment.Exit(0);
            }

            b = float.Parse(args[0]);
            a = float.Parse(args[1]);
            area = b*a/2;
            Console.WriteLine($"El trinagulo de base:{b} y altura: {a} tiene un are de:{area}");

        }
    }
}
