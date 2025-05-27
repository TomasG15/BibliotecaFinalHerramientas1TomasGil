using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_final_Herramientas_1
{
    public enum Rol { Estudiante, Profesor, Administrativo }


    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public Rol Rol { get; set; }
        public List<Material> MaterialesPrestados { get; set; }
        public int Codigo { get; internal set; }
        public bool EsAutor { get; internal set; }

        public Persona(string cedula, string nombre, Rol rol)
        {
            Cedula = cedula;
            Nombre = nombre;
            Rol = rol;
            MaterialesPrestados = new List<Material>();
        }

        public int LimitePrestamos()
        {
            switch (Rol)
            {
                case Rol.Estudiante:
                    return 5;
                case Rol.Profesor:
                    return 3;
                case Rol.Administrativo:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}


    

