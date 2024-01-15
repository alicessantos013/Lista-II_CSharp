using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //processamento de dados
   int N,f;
//dados processados   
  Console.Write ("Digite o valor de N:");
    N = int.Parse(Console.ReadLine());
//calculando
    for(f = 1; N<=1; N=N-1)
  {
    f = f * N;
  }
  Console.WriteLine ("numero inteiro {0}",f);

  }
}