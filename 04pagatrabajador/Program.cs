using System;

namespace _04pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int totalhoras;
            double paga, tasa = 0.3;
            int diferencia;
            double extra =0;
            double pagabruta, normal =0, pagaNeta,impuesto;
            Console.WriteLine("programa que calcula l paga de un trabajador\n\n");
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Horas: ");
            totalhoras = int.Parse(Console.ReadLine());
            Console.WriteLine("Paga: ");
            paga = double.Parse(Console.ReadLine());

            diferencia = totalhoras - 40; 

            if(diferencia >0){
                extra = diferencia* (paga*2);
                normal = 40*paga;
            }else{
                normal = totalhoras*paga;
            }

            pagabruta = extra + normal;
            impuesto = pagabruta * .3;
            pagaNeta = pagabruta - impuesto;

            Console.WriteLine($"{nombre} hola trabajaste {totalhoras} horas a una\npaga de {paga} pesos por hora\ncon una paga bruta de {pagabruta} y una paga neta de {pagaNeta}");


            
            
            


        }
    }
}
