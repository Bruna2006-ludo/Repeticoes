var senhaCorreta = "18019605";
Console.Write("Digite a senha: ");
var senhaDigitada = Console.ReadLine();


while(senhaCorreta != senhaDigitada)
{ 
      Console.WriteLine("Senha incorreta! Tente novamente:");
      senhaDigitada = Console.ReadLine();
}

Console.WriteLine("Acesso liberado! Bem-vinda ao sistema!");