namespace clase8
{
    public class Audi : Auto
    {
        public string Modelo {  get; set; }
        public Audi(string placa, int hp, string color, string modelo) : base(placa, hp, color)
        {
            Modelo = modelo;
        }
        public 
        {
            Console.WriteLine("Modelo: {0} - HP: {1} - Color: {2} - Placa: {3}", Modelo, HP, Color, Placa);

        }