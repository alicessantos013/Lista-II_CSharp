using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //dados iniciais
   int qt;
  double vl,vlt, troco;
  string type;
    
  Console.Write("Digite o tipo do bilhete:(1)unitário, (2)duplo ou (3)10 viagens:");
  type = Console.ReadLine();
  Console.WriteLine("Digite a quantidade de bilhetes que o passageiro solicitou:");
  qt = int.Parse(Console.ReadLine());
  Console.WriteLine("Digite o valor pago pelo passageiro:");
  vl = double.Parse(Console.ReadLine());

vl = vl * qt;
      if(type == "1")
    {
    vlt = vl * 1.30;
    troco = vlt - vl;
    Console.WriteLine("O troco do passageiro será:{0:c}", troco);
    }
      if (type == "2")
    {
    vlt = vl * 2.60;
    troco = vlt - vl;
    Console.WriteLine("O troco do passageiro será:{0:c}", troco);
    }
      if (type == "3")//e se 
    {
    vlt = vl * 12.00;
    troco = vlt - vl;
    Console.WriteLine("O troco do passageiro será:{0:c}", troco);
    }
    Console.ReadKey();
    
  }
}