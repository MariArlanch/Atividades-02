int numero;

do
{
    Console.Write("Digite um número positivo: ");
    numero = int.Parse(Console.ReadLine());

    if (numero <= 0)
    {
        Console.WriteLine("Erro: O número deve ser positivo. Tente novamente.\n");
    }

} while (numero <= 0); 

Console.WriteLine($"\nTabuada do número {numero}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();