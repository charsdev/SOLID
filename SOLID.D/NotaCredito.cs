using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(DateTime fecha, double importe, int numero) : base(fecha, importe, numero)
        {
            Sigla = "NC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Nota De Credito {Numero} del {Fecha.ToShortDateString()} por un importe de {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}
