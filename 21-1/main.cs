using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
  double[] nota = new double[3];
  double media = 0;
  int i;
  for (i = 0; i <= 2; i++)
  {
    Console.Write("Digite a {0}º nota do aluno:", i + 1);
    nota[i] = double.Parse(Console.ReadLine());
    media = media + nota[1];
  }
  media = media / 3;
  if (media >= 7)
  {
  Console.WriteLine("A média do aluno é {0}, o aluno está aprovado", media);
  }
  else
  {
  Console.WriteLine("A média do aluno é {0}, o aluno está reprovado", media);
  }
  Console.ReadKey();

  }
}