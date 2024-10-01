try
{ 
    Console.Write("Digite o primeiro número: ");
    int numero1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());

    int soma = numero1 + numero2;

    Console.WriteLine($"A soma de {numero1} + {numero2} é: {soma}");
}
catch (FormatException)
{
    Console.WriteLine("\nErro: Você deve digitar um número válido.");
}


    Console.WriteLine("\nPressione qualquer tecla para encerrar...");
    Console.ReadKey();

