using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class Factura : DocumentoContable
    {
        public Factura(int numero) : base(numero)
        {
        }

        public override string Descripcion()
        {
            return $"FC-{Numero}";
        }
    }
}
