using System;

namespace SOLID.L
{
    internal class NotaDebito : DocumentoContable
    {
        public NotaDebito(DateTime fecha, int numero) : base(fecha, numero)
        {
            Sigla = "ND";
        }
    }
}