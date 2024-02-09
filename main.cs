/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        NaturalToLow(n,m);
  }
  static void NaturalToLow(int n, int m)
        {
            if (m > n)
            {
                return;
            }
            else
            {
                NaturalToLow(n, m + 1);
                Console.Write(m + " ");
            }
        }
}
