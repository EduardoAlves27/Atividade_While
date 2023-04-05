
Console.WriteLine($"Ola, Bom dia ");
Console.WriteLine($"Hoje Iremos validar algumas infiomacoes");
Thread.Sleep(2000);
Console.Clear();

Console.WriteLine($"Informe seu nome, por gentileza");
string nome = Console.ReadLine().Trim(' ');

while (string.IsNullOrEmpty(nome))
{
    Console.WriteLine($"Bom Voce nao digitou nada, tente novamente ");
    nome = Console.ReadLine().Trim(' ');

}

Console.WriteLine($"Obrigado, ja te indentificamos ");
Thread.Sleep(1500);
Console.Clear();

Console.WriteLine($"Agora vamos verificar sua idade");
Console.WriteLine($"Por favor informe sua idade");
int idade = int.Parse(Console.ReadLine());

while (idade <= 0 || idade > 100)
{
    if (idade > 100)
    {
        Console.WriteLine($"Meu senhor voce nao consegue participar do nosso programa, perdao");
        Console.WriteLine($"Digite novamente a idade");
        idade = int.Parse(Console.ReadLine());

    }

    else
    {
        Console.WriteLine($"Voce ainda  nem existe");
        Console.WriteLine($"Digite novamente a idade");
        idade = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine($"Validamos sua idade");
Thread.Sleep(1500);
Console.Clear();

Console.WriteLine($"Agora iremos validar seu salario");
Console.WriteLine($"Por favor digite seu salario");
float grana = float.Parse(Console.ReadLine());

while (grana <= 0)
{
    Console.WriteLine($"So gostariamos de saber seu salrio para colocar no nosso registro");
    Console.WriteLine($"TEnte informar novamente");
    grana = float.Parse(Console.ReadLine());

}

Console.WriteLine($"Obrigado por informar seu salario");
Thread.Sleep(1500);
Console.Clear();

Console.WriteLine($"Para finalizar nossa pesquisa informe seu estado civil");
Thread.Sleep(1500);

Console.WriteLine($" 's' Para Solteiro(a)");
Console.WriteLine($" 'c' para Casado(a)");
Console.WriteLine($" 'd' para Divorciado(a)");
Console.WriteLine($" 'v' para Viuvo(a)");
string momento = Console.ReadLine().ToLower();

while (momento != "s" && momento != "c" && momento != "d" && momento != "v")
{
    Console.WriteLine($"Bom voce nao digitou uma informcao incorrespondente");
    Console.WriteLine($"Entao tente novamente");
    momento = Console.ReadLine().ToLower();
}

Console.WriteLine($"Bom voce digitou todas as informacoes");

Console.WriteLine($"Muito Obrigado pela compreencao");
Thread.Sleep(3000);
Console.Clear();







