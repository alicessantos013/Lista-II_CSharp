using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//variavel principal    
  int[] n = new int[2];
  for (int i = 0; i < 2; i++)
    {
Console.Write("Insira o {0}º valor: ", i + 1);
  n[i] = int.Parse(Console.ReadLine());
    }
  if (n[1] > n[0])
    {
Console.Write("{0} é o maior número", n[1]);
    }
    else if (n[0] > n[1])
    {
Console.Write("{0} é o maior número", n[0]);
    }
    else
    {
Console.Write("Os números são iguais");
    }
Console.ReadKey();
    }
}
