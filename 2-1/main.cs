using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//DADOS INICIAIS
    int[] n = new int[10];
    int qtdnum = 0;
    for (int i = 0; i < 10; i++)
            {
//PROCESSAMENTO DE DADOS
  Console.Write("Insira o {0}º número: ", i + 1);
     n[i] = int.Parse(Console.ReadLine());
     if (n[i] >= 30 && n[i] <= 90)
              {
     qtdnum += 1;
          }
      }
  Console.Write("Há {0} números entre 30 e 90.", qtdnum);
  Console.ReadKey();
    }
}
