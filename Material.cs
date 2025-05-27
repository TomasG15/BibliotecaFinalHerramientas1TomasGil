public class Material
{
    public string Codigo { get; set; } 
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Material(string titulo, string autor, string codigo)
    {
        Titulo = titulo;
        Autor = autor;
        Codigo = codigo;
    }
}
