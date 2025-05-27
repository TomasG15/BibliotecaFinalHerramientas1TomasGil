using System;

namespace Biblioteca_final_Herramientas_1
{
    public class Prestamo
    {
        private string codigoPersona;
        private string material;
        private DateTime now;

        public Prestamo(string codigoPersona, string material, DateTime now)
        {
            this.codigoPersona = codigoPersona;
            this.material = material;
            this.now = now;
        }

        public Prestamo(int codigoPersona, string nombrePersona, string tituloLibro, string autor, DateTime fecha)
        {
            CodigoPersona = codigoPersona;
            NombrePersona = nombrePersona;
            TituloLibro = tituloLibro;
            Autor = autor;
            Fecha = fecha;
        }

        public int CodigoPersona { get; set; }
        public string NombrePersona { get; set; }
        public string TituloLibro { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
    }
}