int numeroSecreto = 7;
int tentativa;

do
{
    Console.Write("Adivinhe o número secreto (entre 1 e 10): ");
    tentativa = int.Parse(Console.ReadLine());

    if (tentativa != numeroSecreto)
    {
        Console.WriteLine("Errado! Tente novamente.\n");
    }

} while (tentativa != numeroSecreto);

Console.WriteLine("\nParabéns! Você acertou!!!");
Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();
    
   