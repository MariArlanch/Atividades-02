int numero;

while (true)
{
    Console.Write("Digite um número inteiro positivo: ");
    bool isNumeroValido = int.TryParse(Console.ReadLine(), out numero);

    if (isNumeroValido && numero > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Erro: Por favor, insira um número inteiro positivo válido.\n");
    }
}

Console.WriteLine($"\nOs valores ímpares até {numero} são:");
for (int i = 1; i <= numero; i++)
{
    if (i % 2 != 0) 
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();