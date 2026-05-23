
namespace clase6;

public class Humano
{
    private string primerNombre;
    private string primerApellido;
    private string colorojos;

    public Humano(string primerNombre)
    {
        this.primerNombre = primerNombre;
    }

    public Humano(string primerNombre, string primerApellido)
    {
        this.primerNombre = primerNombre;
        this.primerApellido = primerApellido;
    }

    public Humano(string primerNombre, string primerApellido, string colorojos)
    {
        this.primerNombre = primerNombre;
        this.primerApellido = primerApellido;
        this.colorojos = colorojos;
    }

    public void Presentarse()
    {
        Console.WriteLine("Hola soy {0}-{1}-(2)", primerNombre, primerApellido, colorojos);
    }
}
