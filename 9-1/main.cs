using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int soma;
    int[] idade = new int[2];
    string[] nome = new string[2];
    for (int i = 0; i < 2; i++)
  {
    //processmento de dados
Console.Write("Insira o {0}º nome: ", i + 1);
  nome[i] = Console.ReadLine();
Console.Write("Insira a idade de {0}: ", nome[i]);
  idade[i] = int.Parse(Console.ReadLine());
  }
    soma = idade[0] + idade[1];
Console.Write("A soma das idades de {0} e {1} é igual a {2}", nome[0], nome[1], soma);
Console.ReadKey();
  }
}