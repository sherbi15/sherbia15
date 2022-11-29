using System;
class Program{
    public static void Main(string[] args)
    {
      int i,fact=1; 
      int n=int.Parse(Console.ReadLine());
      for(i=1;i<=n;i++){
        fact=fact*i;
        
      }
      Console.WriteLine(fact);
      
    }
} 
