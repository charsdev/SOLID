using System;

namespace SOLID.O
{
    public abstract class DocumentoContable
    {
        public DateTime Fecha { get; set; }
        public Double Importe { get; set; }
        protected int Numero;

        public DocumentoContable(int numero)
        {
            Numero = numero;
        }

        public abstract string Descripcion();
    }
}
