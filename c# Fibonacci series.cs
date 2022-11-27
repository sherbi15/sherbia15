using System;
class Program{
    public static void Main(string[] args)
    {
        int n1=0,n2=1,n3;
        int n=Convert.ToInt32(Console.ReadLine());
        Console.Write(n1+" "+n2+" ");
        for(int i=2;i<n;i++)
        {
            
            n3=n1+n2;
            Console.Write(n3+" ");
            n1=n2;
            n2=n3;
        }
    }
}


