using System;

namespace SOLID.L
{
    public class Factura : DocumentoContable
    {
        public Factura(DateTime fecha, int numero) : base(fecha, numero)
        {
            Sigla = "FC";
        }
    }

}
