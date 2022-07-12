using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe, string codigoDePago) : base(importe)
        {
            CodigoDePago = codigoDePago;
        }
        public string CodigoDePago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Impuesto Municipal {CodigoDePago} con valor de {Importe}");
        }
    }

}
