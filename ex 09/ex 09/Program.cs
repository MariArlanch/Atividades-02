string[] diasSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };

string[] tarefas = new string[diasSemana.Length];

for (int i = 0; i < diasSemana.Length; i++)
{
    Console.Write($"Insira a tarefa para {diasSemana[i]}: ");
    tarefas[i] = Console.ReadLine();
}

Console.WriteLine("Tarefas da semana:");
for (int i = 0; i < diasSemana.Length; i++)
{
    Console.WriteLine($"{diasSemana[i]}: {tarefas[i]}");
}

Console.ReadKey();
