// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static  int FindModuloX(int a,int b,int modulo)
    {
        int x = 0;
        
        for(int i = 0;i<1000;i++)
        {
            x+=1;
            if((a*x-b) % modulo == 0)
            {
                 return x;
            }
        }
        return 0;
    }

    public static void Main(string[] args)
    {
        int mod = 0,a = 0,b = 0;
        Console.WriteLine("podaj liczbe stojaca przy x");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("podaj liczbe po =");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("podaj modulo");
        mod = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("wynik = "+FindModuloX(a,b,mod));
    }
}
