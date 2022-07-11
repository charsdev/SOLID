using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public class FacturaElectronica : Documento, IEmaileable
    {
        public FacturaElectronica(DateTime fecha, int numero) : base(fecha, numero)
        {
        }
        public void EnviarPorMail()
        {
            Console.WriteLine($"Enviando por email la factura electrónica {Numero} del dia {Fecha.ToShortDateString()}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electrónica {Numero} del dia {Fecha.ToShortDateString()}");

        }

        public string CAE { get; set; }
    }
}
