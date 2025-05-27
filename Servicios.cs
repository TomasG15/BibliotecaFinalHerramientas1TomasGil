using Biblioteca_final_Herramientas_1;
using System;
using System.Collections.Generic;

public static class Servicios
{
    private static List<Persona> personas = new List<Persona>();
    private static List<Material> materiales = new List<Material>();
    private static List<Prestamo> prestamos = new List<Prestamo>();
    private static List<Autor> autores = new List<Autor>();

    
    public static List<Prestamo> ListaMovimientos { get; } = new List<Prestamo>();

    
    public static List<Material> ListaMateriales => materiales;
    public static void GuardarPersona(Persona p)
    {
        personas.Add(p);
    }

    public static List<Persona> ObtenerPersonas()
    {
        return personas;
    }
    public static void GuardarMaterial(Material m)
    {
        materiales.Add(m);
    }

    public static List<Material> ObtenerMateriales()
    {
        return materiales;
    }

    public static List<Persona> ObtenerAutores()

    {
        return personas.FindAll(p => p.EsAutor); ;
    }

   
    public static void GuardarPrestamo(Prestamo nuevoPrestamo)
    {
        prestamos.Add(nuevoPrestamo);
        ListaMovimientos.Add(nuevoPrestamo);
    }

    public static List<Prestamo> ObtenerPrestamos()
    {
        return prestamos;
    }
}

