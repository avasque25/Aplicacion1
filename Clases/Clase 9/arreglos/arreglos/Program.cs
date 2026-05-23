
using System.Diagnostics.Contracts;

int[] arreglo1 = new int[10];

int[] arreglo2 = new int[] {1,2,3,4,5};

int[] arreglo3 = {1,5,7,6};



arreglo1[0] = 10;
arreglo1[1] = 12;
arreglo1[2] = 3;

Console.WriteLine(arreglo1[0]);


for (int i = 0; i < arreglo1.Length; i++)
{
    Console.WriteLine("posicion {0} valor {1}", i, arreglo1[i]);
}

ArregloMultidimencional();
static void ArregloMultidimencional()
{
    string[,] matriz2d = new string[,]
        {
            {"A","B","C"},
            {"D","E","F"},
            {"G","H","I"}
        };
    string[,,] matriz3d = new string[,,]
        {
            {
                {"A","B","C"},
                {"D","E","F"},
            },
            {
                {"A","B","C"},
                {"D","E","F"},
            }
        };
    Console.WriteLine(matriz2d[2,1]);

    matriz2d[2, 2] = "x";
    for (int i = 0; i < matriz2d.GetLength(0); i++)
    {
        for (int j = 0; j < matriz2d.GetLength(1); j++)
        {
            Console.Write(matriz2d[i, j]);
        }
        
    }
}