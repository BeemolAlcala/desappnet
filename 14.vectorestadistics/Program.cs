using System;

namespace _14.vectorestadistics
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] A;
           int n=0;
           Console.WriteLine("Cuantos elementos ?");
           n = int.Parse(Console.ReadLine());
           A = new double[n];
           
           Console.WriteLine("DAme los elementos del arreglo");
           leer(A);
           Console.Write("El Arreglo es: ");
           imprime(A);
           Console.WriteLine($"\nMayor: {mayor(A)}");
           Console.WriteLine($"Menor: {menor(A)}");
           Console.WriteLine($"El promedio es: {media(A)}");
           Console.WriteLine($"La varianza es: {varianza(A,media(A))}");
           Console.WriteLine($"Desviacion estandar es: {Math.Sqrt(varianza(A,media(A)))}");
        }

        static void leer(double[] v){
            for(int i=0;i<v.Length;i++){
               Console.WriteLine($"Elemento [{i+1}] = ");
               v[i]= double.Parse(Console.ReadLine());
            }
        }
        
        static double mayor(double[]v){
            double m = v[0];
            for(int i=1;i<v.Length;i++){
                if(v[i]>m){
                    m = v[i];
                }
            }

            return m;
        }
        static double menor(double[]v){
            double m = v[0];
            for(int i=1;i<v.Length;i++){
                if(v[i]<m){
                    m = v[i];
                }
            }

            return m;
        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                    Console.Write($"{v[i]} ");
            }
        }
        static double media(double[]v){
            double s=0;
            for(int i=0;i<v.Length;i++){
                s+=v[i];

            }
            return s/v.Length;
        }

        static double varianza(double[]v,double media){
            double s=0;
            for(int i=0;i<v.Length;i++){
                s+= Math.Pow(v[i]-media,2);

            }
            return s/v.Length-1;
        }


    }
}
