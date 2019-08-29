using System;

namespace _08.vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100
            };

            int suma=0, contador=0;
            float promedio=0;
            Console.WriteLine("Los elementos del arreglo son:\n");
            for(int i=0;i<vector.Length;i++){

                Console.Write($"{vector[i]} ");
                suma += vector[i];
            }

            promedio = suma/vector.Length;
            Console.WriteLine($"\nEl promedio es: {promedio}\n");
            Console.WriteLine("\nNumeros mayores que el promedio \n");
            for(int i=1;i<vector.Length;i++){

               if(vector[i]>promedio){
                   Console.Write($"{vector[i]} ");
                   contador++;
               }
            }

            Console.WriteLine($"\nMayor que el promedio {contador}");
        }
    }
}
