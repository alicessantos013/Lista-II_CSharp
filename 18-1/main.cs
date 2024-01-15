using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
  //dados  
    double vl, parc, comissao;
    string pag;
    Console.Write("Digite o valor da compra:");
    vl = double.Parse(Console.ReadLine());
    vl = vl + vl * 0.10;
    Console.Write("Qual o tipo de pagamento (p)parcelado e (v)à vista:");
    pag = Console.ReadLine();
    if (pag == "v")
    {
    Console.Write("O valor a ser pago é {0:c}", vl);
    comissao = vl * 0.05;
    Console.Write("A comissão do funcionário será {0}", comissao);
    }
    else
    {
    parc = vl / 3;
    Console.Write("O valor será pago em 3 parcelas de {0:c}", parc );
    comissao = vl * 0.10;
    Console.Write("A comissão do funcionário será {0}", comissao);
    }
    Console.ReadKey();

  }
}