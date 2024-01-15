using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//dados      
    string[] sex = new string[5];
    int[] id = new int[5];
    int totm = 0, toth = 0, somidm = 0, somidh = 0, somid = 0, medidm = 0, medidh = 0, medid = 0;
    for (int i = 0; i < 5; i++)
      {
//processamento de dados        
  Console.Write("Insira o sexo da {0}ª pessoa [M/F]: ", i + 1);
    sex[i] = Console.ReadLine();
  Console.Write("Insira a idade da {0}ª pessoa: ", i + 1);
      id[i] = int.Parse(Console.ReadLine());
      somid += id[i];
      if (sex[i] == "M")
      {
      toth += 1;
      somidh += id[i];
       }
      if (sex[i] == "F")
       {
      totm += 1;
      somidm += id[i];
        }
        }
  Console.WriteLine("");
      medid = somid / 5;
  Console.WriteLine("Média das idades do grupo: {0}", medid);
    if (toth > 0)
     {
     medidh = somidh / toth;
  Console.WriteLine("Média das idades dos homens: {0}", medidh);
      }
    if (totm > 0)
    {
    medidm = somidm / totm;
  Console.Write("Média das idades dos homens: {0}", medidm);
    }
  Console.ReadKey();
  }
}