using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
  //dados  
double[] temp = new double[1];
double c;
int i = 1;
do
{
 //processamento de dados 
Console.WriteLine("Digite a temperatura em Fahrenheit:");
temp[0] = double.Parse(Console.ReadLine());
//calculando
c = (temp[0] - 32) / 1.8;
Console.WriteLine("A temperatura digitada em Fahrenheit é igual a {0} graus celsius", c);
} while (i > 0);
Console.ReadKey();
  }
}
