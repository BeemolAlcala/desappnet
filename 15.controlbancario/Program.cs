using System;
using ControlBancario.Clases;
namespace ControlBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria micuenta1 = new CuentaBancaria();
            CuentaBancaria micuenta2 = new CuentaBancaria(1000);
            CuentaDeAhorros miahorro = new CuentaDeAhorros(600,0.3);
            CuentaDeCheques micheque = new CuentaDeCheques(5000,1000);



            miahorro.Deposita(100);
            miahorro.Retira(50);
            micuenta1.Deposita(300);
            micuenta2.Retira(500);
            micheque.Deposita(3000);
            micheque.Retira(9000);

            Console.WriteLine(micuenta1.Saldo);
            Console.WriteLine(micuenta2.Saldo);
            Console.WriteLine(miahorro.Saldo);
            Console.WriteLine(micheque.Saldo);

            //Clintes
            Cliente cte1 = new Cliente("Jesus de veracruz");
            Cliente cte2 = new Cliente("Lolita ayala");
            Cliente cte3 = new Cliente("Lord Peña");
            Cliente cte4 = new Cliente("Cabecita de algodon");
            Banco MiBanco = new Banco("Mac Pato Ritch SA. de CV.");
            cte1.AgregarCuenta(new CuentaDeCheques(2000,1000));
            cte2.AgregarCuenta(new CuentaDeCheques(1000,200));
            cte3.AgregarCuenta(new CuentaDeCheques(900,100));
            cte4.AgregarCuenta(new CuentaDeCheques(12000,1000));
            cte1.AgregarCuenta(new CuentaDeAhorros(2000,0.3));

            
            cte1.Cuentas[0].Retira(300);
            cte3.Cuentas[0].Deposita(1200);
            cte4.Cuentas[0].Retira(1000);
            
            MiBanco.AgregarCliente(cte1);
            MiBanco.AgregarCliente(cte2);
            MiBanco.AgregarCliente(cte3);
            MiBanco.AgregarCliente(cte4);

            MiBanco.AgregarCliente(new Cliente("Tello Chorejas"));
            MiBanco.Clientes[4].AgregarCuenta(new CuentaDeCheques(3000,900));
            Console.WriteLine("------Reporte de Clientes-------");
            Console.WriteLine($"{MiBanco.Nombre}");
            foreach(Cliente cte in MiBanco.Clientes){
                Console.WriteLine($"Cliente {cte.Nombre}");
                foreach(CuentaBancaria cta in cte.Cuentas){
                    if(cta is CuentaDeAhorros){
                        Console.WriteLine($"Cuenta de ahorros {cta.Saldo} ");
                    }else{
                        Console.WriteLine($"Cuenta de cheques {cta.Saldo} ");
                    }
                }
            }
        }
    }
}
