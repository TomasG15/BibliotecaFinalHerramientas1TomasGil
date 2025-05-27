using System;

public class Movimiento
{
    public string CodigoPersona { get; set; }
    public string Material { get; set; }
    public DateTime Fecha { get; set; }

    public Movimiento(string codigoPersona, string material, DateTime fecha)
    {
        CodigoPersona = codigoPersona;
        Material = material;
        Fecha = fecha;
    }
}

