using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
 //variaveis   
int x;
double y, z, result;
//processamento de dados
Console.Write("Digite o valor de x:");
  x = int.Parse(Console.ReadLine());
Console.Write("Digite o valor de y:");
  y = int.Parse(Console.ReadLine());
Console.Write("Digite o valor de z:");
//calculando
  z = int.Parse(Console.ReadLine());
  x = x * 10;
  result = ((x+5)*y) * z;
Console.Write("O resultado da expressão (( x 5) *y)z é:{0}", result);
Console.ReadKey();

  }
}