using System;
using Interfaces.Clases;
using System.Collections.Generic;

namespace _16.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Caja> costal = LlenarCostal();
           Caja miCaja = new Caja("Roja",true,"calzones",10,20);
           Console.WriteLine();
           Console.WriteLine("Ejemplo de Interface \n\n");
           costal.Add(miCaja);
           foreach(Caja c in costal){
            Console.WriteLine($"Color:{c.Color} \nEstatus:{(c.EstaAbierta?"Abierta":"Cerrada")} \nContenido:{(c.EstaAbierta?c.Contenido:"Nel")} \nDimensiones: {c.Medidas()} ");
           }
        }
        static List<Caja> LlenarCostal(){
            List<Caja> todo = new List<Caja>();
            todo.Add(new Caja("Rojo",false,"Manzanas",10,10));
            todo.Add(new Caja("Verde",false,"pepinos",10,10));
            todo.Add(new Caja("Azul",false,"Nubes",10,10));
            todo.Add(new Caja("Negro",false,"CArbon",10,10));
            todo.Add(new Caja("Blanca",false,"Manzanas",10,10));
            todo.Add(new Caja("Rosa",false,"Flores",10,10));
            todo.Add(new Caja("Gris",false,"PLayera",10,10));

            return todo;
        }
    }
}
