
//casting implicito
int valor = 200;
double total = valor;
Console.WriteLine("implicito " + total);

//casting explicito
double precio = 500.23;
int descuento = (int)precio;
Console.WriteLine("explicito " + descuento);

char letra = 'A';
int codigoAscii = letra;
Console.WriteLine(codigoAscii);

string palabra = "123456";
int numero = Convert.ToInt32(palabra);
Console.WriteLine(numero);

string textodecimal = "150.60";
double valor3 = double.Parse(textodecimal);
Console.WriteLine(valor3);



Console.ReadKey();