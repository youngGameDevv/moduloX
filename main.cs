// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int mod(int k, int n) {  return ((k %= n) < 0) ? k+n : k;  }
    static  int FindModuloX(int a,int b,int modulo)
    {
        for(int i = 0;i<1000;i++)
        {
            if(mod(a*i-b,modulo) == 0)
                return i;
        }
        return 0;
    }
    static bool isCorrect(int a,int b,int modulo)
    {
        return mod(a-b,modulo) == 0 ? true : false;
    }

    public static void Main(string[] args)
    {
        int mod = 0,a = 0,b = 0,selectMode = 1;
        Console.WriteLine("obliczanie x wybierz 1");
        Console.WriteLine("sprawdzanie poprawnosci wybierz 2");
        selectMode = Int32.Parse(Console.ReadLine());
        Console.WriteLine("podaj liczbe stojaca przy x");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("podaj liczbe po =");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("podaj modulo");
        mod = Int32.Parse(Console.ReadLine());
        
        if(selectMode == 1)
            Console.WriteLine("wynik = "+FindModuloX(a,b,mod));
        else
            Console.WriteLine("wynik = "+isCorrect(a,b,mod));
    }
}
