using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
//dados 
    double[] idade = new double[10];
    double[] peso = new double[10];
    double[] altura = new double[10];
    double media = 0, percent = 0;
    int cont1 = 0, cont2 = 0, cont3 = 0;
    for (int i = 0; i <= 9; i++)
      {
  Console.Write("Digite a altura da {0}º pessoa", i + 1);
    altura[i] = double.Parse(Console.ReadLine());
  Console.Write("Digite o peso da {0}º pessoa", i + 1);
    peso[i] = double.Parse(Console.ReadLine());
  Console.Write("Digite a idade da {0}º pessoa", i + 1);
    idade[i] = double.Parse(Console.ReadLine());
//CALCULOS
    media = media + idade[i];
    if (peso[i] > 90 && altura[i] < 1.50)
  {
    cont1 = cont1 + 1;
  }
    else if(idade[i] >= 10 && idade[i] <= 30 && altura[i] > 1.90)
  {
    cont2 = cont2 + 1;
  }
    else if (altura[i] > 1.90)
  {
    cont3 = cont3 + 1;
  }
    media = media / 10;
    percent = percent + (cont2 * 100) / cont3;
  Console.WriteLine("A média de idade das 10 pessoas é:{0}", media);
  Console.WriteLine("A quantidade de pessoas com peso superior a 90 quilos e altura inferior a 1.50 é:{0}", cont1);
  Console.WriteLine("A porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de 1.90 é:{0}%", percent);
  Console.ReadKey();
    }
  }
}