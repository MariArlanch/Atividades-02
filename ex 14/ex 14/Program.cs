int opcao;

    Console.WriteLine("\nMenu de Opções:");
    Console.WriteLine("1. Exibir uma mensagem");
    Console.WriteLine("2. Fazer uma soma");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nVocê escolheu exibir uma mensagem.");
            Console.WriteLine("Mensagem: Olá, sou a Mari:)");
            break;

        case 2:
            Console.WriteLine("\nVocê escolheu fazer uma soma.");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine($"\nA soma de {numero1} + {numero2} é: {soma}\n");
            break;

        case 3:
            Console.WriteLine("\nVocê escolheu sair. Pressione qualquer tecla para encerrar...");
            break;

        default:
            Console.WriteLine("\nOpção inválida! Por favor, escolha uma opção válida.");
            break;
    }

Console.ReadKey();