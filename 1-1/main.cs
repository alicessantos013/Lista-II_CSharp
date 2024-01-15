using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//DADOS INICIAIS
    int[] p = new int[7];
    int[] id = new int[7];
    int somid = 0, medid, qtdnove = 0;
    for (int i = 0; i < 7; i++)
      {
//PROCESSAMENTO DE DADOS
  Console.Write("Insira o peso da {0}ª pessoa: ", i + 1);
    p[i] = int.Parse(Console.ReadLine());
    if (p[i] > 90)
      {
    qtdnove += 1;
      }
  Console.Write("Insira a idade da {0}ª pessoa: ", i + 1);
    id[i] = int.Parse(Console.ReadLine());
    somid += id[i];
      }
    medid = somid / 7;
  Console.WriteLine("No grupo há {0} pessoas acima dos 90kg.", qtdnove);
  Console.Write("Média das idades das pessoas: {0}", medid);
  Console.ReadKey();
        }
    }

