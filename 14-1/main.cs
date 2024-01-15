using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
     // dados   
    double[] nota = new double[2];
    double[] peso = new double[2];
    double notaf, pesof, result;
    for( int i = 0; i < 2; i++)
    {
    //processamento de dados  
    Console.Write("Insira a {0}º nota: ", i + 1);
    nota[i] = double.Parse(Console.ReadLine());
    Console.Write("Insira o peso da {0}º nota: ", i + 1);
    peso[i] = double.Parse(Console.ReadLine());
    }
    //calculando
    notaf = nota[0] + nota[1];
    pesof = peso[0] + peso[1];
    result = notaf / pesof;
    Console.Write("A média ponderada do aluno é:{0}", result);
    Console.ReadKey();
  }
}