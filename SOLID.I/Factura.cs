using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public class Factura : Documento
    {
        public Factura(DateTime fecha, int numero) : base(fecha, numero)
        {
        }

        public string CAI { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del dia {Fecha.ToShortDateString()}");
        }
    }

}
