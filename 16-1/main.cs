using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //dados
   double result=0 , l;
   l = 520 / 12;
   result = result + l * 1.5;
  
   Console.Write("Maria terá que colocar {0} litros no carro para realizar a viagem de 520km gastando um total de {0:c} no combustivel", l, result);
  Console.ReadKey();

  }
}