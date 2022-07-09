using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class NotaDebito : DocumentoContable
    {
        public NotaDebito(int numero) : base(numero)
        {
        }

        public override string Descripcion()
        {
            return $"ND-{Numero}";
        }
    }
}
