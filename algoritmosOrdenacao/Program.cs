using System.Security.Cryptography;
int tamanho = 10;
int[] matriz = new int[tamanho];
int aux;

for (int i = 0; i < tamanho; i++)
{
    matriz[i] = RandomNumberGenerator.GetInt32(1, 9);
}

for (int i = 0; i < tamanho; i++)
{
    Console.Write(matriz[i] + " ");
}

//ordenação
int contador = tamanho - 1;
for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < contador; j++)
    {
        if (matriz[j] > matriz[j + 1])
        {
            aux = matriz[j];
            matriz[j] = matriz[j + 1];
            matriz[j + 1] = aux;
        }
    }
    contador--;
}
Console.WriteLine();

for (int i = 0; i < tamanho; i++)
{
    Console.Write(matriz[i] + " ");
}
