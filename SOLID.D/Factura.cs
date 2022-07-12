using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Factura : DocumentoContable
    {
        public Factura(DateTime fecha, double importe, int numero) : base(fecha, importe, numero)
        {
            Sigla = "FC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura {Numero} del {Fecha.ToShortDateString()} por un importe de {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21;
        }
    }
}
