try
{
    Console.Write("Digite a nota do aluno (0 a 100): ");
    int nota = int.Parse(Console.ReadLine());

    if (nota < 0 || nota > 100)
    {
        Console.WriteLine("Erro: A nota deve estar entre 0 e 100.");
    }
    else
    {
        char classificacao;

        if (nota >= 90 && nota <= 100)
        {
            classificacao = 'A';
        }
        else if (nota >= 80 && nota <= 89)
        {
            classificacao = 'B';
        }
        else if (nota >= 70 && nota <= 79)
        {
            classificacao = 'C';
        }
        else if (nota >= 60 && nota <= 69)
        {
            classificacao = 'D';
        }
        else
        {
            classificacao = 'F';
        }

        Console.WriteLine($"A classificação da nota {nota} é: {classificacao}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Erro: Você deve digitar um número válido.");
}

    Console.WriteLine("\nPressione qualquer tecla para encerrar...");
    Console.ReadKey();