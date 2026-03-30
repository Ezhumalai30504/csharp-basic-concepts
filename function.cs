using System;

namespace MyProject
{
    class Function
    {
      //----Static function (Function Parameter Without  Return Type)----

        static void  AddNum(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("\nStatic Function");
            Console.WriteLine("Sum of a + b = "+sum);
        }
        //-----Non-Static Function(Function With Parameter With Return Type)----

        int Add(int a,int b)
        {
            return a+b;
        }

        static void Main()
        {
           Console.Write("Enter First Number:");
           int Num1 = int.Parse(Console.ReadLine());
           Console.Write("Enter Second Number:");
           int Num2 = int.Parse(Console.ReadLine());
           AddNum(Num1,Num2);

          //

           Function cal = new Function();
           int Result = cal.Add(Num1,Num2);
           Console.WriteLine("\nNon-Static Function");
           Console.WriteLine("Add of a + b = "+Result); 
        }
    }
}