using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Remito : IImprimible
    {
        public Remito(int numero, DateTime fecha, int cantidadBultos)
        {
           Numero = numero;
           Fecha = fecha;
           CantidadBultos = cantidadBultos;
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadBultos { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Remito {Numero} del {Fecha} con una cantidad de {CantidadBultos}");
        }
    }

}
