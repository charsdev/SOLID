using System;

namespace SOLID.L
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(DateTime fecha, int numero) : base(fecha, numero)
        {
            Sigla = "NC";
        }
    }
}
