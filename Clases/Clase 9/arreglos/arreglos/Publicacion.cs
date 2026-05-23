using System.Runtime.CompilerServices;

namespace Publicacion;

public class Publicacion
{
    private static int PublicacionID;
    private int ID;
    private string Titulo;
    private string Autor;
    private bool esPublico;

    public Publicacion(int id, string titulo, string autor, bool esPublico)
    {
        this.ID = id; 
        Titulo = titulo;
        Autor = autor;
        this.esPublico = esPublico;
    }

    static void Editar(string titulo, bool esPublico)
    {
        
    }
}