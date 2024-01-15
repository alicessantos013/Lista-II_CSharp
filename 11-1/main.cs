using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
  //Variaveis   
  int troca;
  int[] var1 = new int[2];
  for (int i = 0; i < 2; i++)
            {
            Console.Write("Digite o valor da {0}º var:", i+1);
  var1[i] = int.Parse(Console.ReadLine());
            }
   troca = var1[0];
   var1[0] = var1[1];
   var1[1] = troca;
            Console.Write("O valor de VA(1ºvar) é: {0}", var1[0]);
            Console.WriteLine("O valor de VB(2ºvar) é: {0}", var1[1]);
            Console.ReadKey();
  }
}