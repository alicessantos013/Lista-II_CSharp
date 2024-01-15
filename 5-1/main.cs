using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//dados iniciais
    int soma = 0;
    for (int i = 0; i < 101; i += 2)
  {
  Console.WriteLine("{0}", i);
    soma += i;
  }
  Console.WriteLine("");
  Console.Write("{0}", soma);
  Console.ReadKey();
    }
  }
