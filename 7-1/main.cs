using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//processamento de dados    
  int result;
  int[] n = new int[2];
  for (int i = 0; i < 2; i++)
    {
Console.Write("Insira o {0}º valor: ", i + 1);
  n[i] = int.Parse(Console.ReadLine());
    }
  result = n[0] * n[1];
  Console.Write("{0} x {1} = {2}", n[0], n[1], result);
  Console.ReadKey();
    }
  }