
namespace clase8;


public class Auto
{
    public string Placa { get; private set; }
    public int HP {  get; set; }
    public string Color { get; set; }

    // Constructor
    public Auto(string placa, int hp, string color)
    {
        Placa = placa;
        HP = hp;
        Color = color;
    }
    //metodos
    public void MostrarDetalles()
    {
        Console.WriteLine("HP: {0} - Color: {1}: Placa {2{");
    }
}
