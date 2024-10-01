Console.Write("Informe um número de 1 a 12, representando um mês do ano: ");
int mes = int.Parse(Console.ReadLine());


switch (mes)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("A estação é o Verão.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("A estação é o Outono.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("A estação é o Inverno.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("A estação é a Primavera.");
        break;
    default:
        Console.WriteLine("Número inválido. Por favor, insira um número entre 1 e 12.");
        break;
}

Console.WriteLine("Pressione qualquer tecla para encerrar...");
Console.ReadKey();
    