using System;
class Program{
  public static void Main (){
    int sa, a, m, d;
    Console.Write("Digite quantos dias a empresa está sem acidentes? ");
    sa = int.Parse(Console.ReadLine());
    a = sa/365; 
    m = (sa%365)/30;
    d = (sa%365)%30;
    Console.WriteLine("A empresa está sem acidentes por {0} ano(s), {1} mês(es) e {2} dia(s).", a, m, d);
  
  }
}

