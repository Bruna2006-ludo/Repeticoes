int contagem = 5;
while (contagem > 0)
{
    Console.WriteLine($"Contagem regressiva: {contagem}");

    contagem--;
    await Task.Delay(1000);
}

Console.WriteLine("Foguete lançado com sucesso!");