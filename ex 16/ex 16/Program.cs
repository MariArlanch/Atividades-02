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

//para alcular o fatorial (achei na internet)
long fatorial = 1;
for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}

Console.WriteLine($"\nO fatorial de {numero} é: {fatorial}");

Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();
