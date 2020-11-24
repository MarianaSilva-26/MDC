using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int A; 
            int B;
            int mdc;
            bool fim = true;

            Console.WriteLine("Máximo Divisor Comum");
            Console.Write("1° número: "); 
            A = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("2° número: ");
            B = Convert.ToInt32(Console.ReadLine());

        while (fim)
        {
        if (A % B ==0)
        {
            Console.WriteLine($"MDC (a, b) = {A}");  
            fim = false; 
        }
        else
        {
            mdc = A % B; 
            A = B; 
            B = mdc; 
        }
        }
        }
    }
}
