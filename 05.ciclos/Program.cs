using System;

namespace _05.ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, c=0, suma=0;
            if(args.Length==0){
                Console.Clear();
                Menu();
                return 1;

            }

            op = int.Parse(args[0]);
            switch(op){
                case 1:
                    int i =1;
                    int j =0;
                    suma =0;
                    while(i<101){
                        Console.Write(i+" ");
                        suma += i;
                        while(j==4){
                            Console.WriteLine("\n");
                            j=0;
                        }
                        j++;
                        i++;
                    } 
                    Console.WriteLine("La suma es: "+suma);
                break;
                
                case 2:
                    i =100;
                    j =0;
                    suma =0;
                    while(i>=1){
                        Console.Write(i+" ");
                        suma += i;
                        while(j==4){
                            Console.WriteLine("\n");
                            j=0;
                        }
                        j++;
                        i--;
                    } 
                    Console.WriteLine("La suma es: "+suma);
                break;

                case 3:
                    
                    for(int k =50;k<201;k++){
                        Console.Write(k+" ");
                        suma += k;
                    }
                    Console.WriteLine("La suma es: "+suma);
                break;

                case 4:

                    for(int k =2;k<101;k+=2){
                        Console.Write(k+" ");
                        suma += k;
                    }
                    Console.WriteLine("La suma es: "+suma);

                break;

                case 5:

                    for(int k =99;k>0;k-=2){
                        Console.Write(k+" ");
                        suma += k;
                    }
                    Console.WriteLine("La suma es: "+suma);

                break;

                case 6:
                    
                    int p=272;
                    while(p>39){
                        Console.Write(p+" ");
                        suma += p;
                        p-=4;
                    }
                    
                    Console.WriteLine("La suma es: "+suma);

                break;
            }
            return 0;
        }

        static void Menu(){
            Console.WriteLine("Menu\n");
            Console.WriteLine("[1] Números del 1 al 100 con ciclo while");
            Console.WriteLine("[2] Números del 100 al 1 con ciclo do .. while");
            Console.WriteLine("[3] Números del 50 al 200 con ciclo for");
            Console.WriteLine("[4] Números del 2 al 100 solo los pares con ciclo for");
            Console.WriteLine("[5] Números del 99 al 1 solo impares ciclo for");
            Console.WriteLine("[6] Números del 40 al 272 en incrementos de 4 con ciclo while");
        }
    }
}
