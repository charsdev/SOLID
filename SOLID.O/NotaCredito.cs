using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero) : base(numero)
        {
        }

        public override string Descripcion()
        {
           return $"NC-{Numero}";
        }
    }
}
