using System;

namespace SOLID.L
{
    public abstract class DocumentoContable
    {
        protected DateTime _fecha;
        protected int _numero;
        protected string Sigla;

        public DocumentoContable(DateTime fecha, int numero)
        {
            _fecha = fecha;
            _numero = numero;
        }

        public string Imprimir()
        {
            return $"Imprimiendo {Description()}";
        }

        public virtual string Description()
        {
            return $"{Sigla} nro {_numero} de fecha {_fecha.ToShortDateString()}";
        }
    }

}
