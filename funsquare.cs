using System;

namespace MyProject
{
    class FunctionSquare
    {
        static int Square()
        {
          Console.Write("\nEnter a Number:");
          int Num = int.Parse(Console.ReadLine());
          return Num*Num;
        }
        static void Main()
        {
          Console.Write("\nEntere a Square of Number:");
          int UserNum = int.Parse(Console.ReadLine());

          for(int i=1;i<=UserNum;i++)
          {
          Console.WriteLine(Square());
          }
        }
    }
}