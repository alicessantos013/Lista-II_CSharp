using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
  //dados    
    double n;
  Console.Write("Digite um número:");
    n = double.Parse(Console.ReadLine());
      if (n % 2 == 1)
    {
  Console.WriteLine("O número digitado é impar");
  }
    else
  {
  Console.WriteLine("O número digitado é par");
  }
  Console.ReadKey();

  }
}