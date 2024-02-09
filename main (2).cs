/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
static void PrintArray(int[] arr, int i) {
    if (i == 0) return;

    Console.Write(arr[i-1] + " ");
    PrintArray(arr, i - 1);
}
static void Main(string[] args)
{
    int[] Array = {1,2,3,4,5};

    PrintArray(Array, Array.Length);
}
}