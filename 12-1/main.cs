using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//variaveis    
  int a, b, c, ab, abc;
 //processamento de dados 
  Console.Write("Digite o Algorismo A:");
  a = int.Parse(Console.ReadLine());
  Console.Write("Digite o Algorismo B:");
  b = int.Parse(Console.ReadLine());
  Console.Write("Digite o Algorismo C:");
  c = int.Parse(Console.ReadLine());
  a = a * 10;
  ab = a + b;
  abc = ab * c;
Console.Write("O resultado da fórmula AB * C é:{0}", abc);
Console.ReadKey();
  }
}