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

        }
    }
}
