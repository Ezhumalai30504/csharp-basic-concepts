using System;
namespace Myproject
{
    class Converter
    {
        static void Main()
        {

            //Implicit Type

            byte ByteValue = 100;
            short ShortValue = ByteValue;
            Console.WriteLine("Short Value = "+ShortValue+""+ShortValue.GetType());

            int IntValue =ShortValue;
            Console.WriteLine("IntValue Value = "+IntValue+""+IntValue.GetType());

            long LongValue = IntValue;
            Console.WriteLine("Long Value = "+LongValue+""+LongValue.GetType());

            float FloatValue = LongValue;
            Console.WriteLine("Float Value = "+FloatValue+""+FloatValue.GetType());

            double DoubleValue = FloatValue;
            Console.WriteLine("Double Value = "+DoubleValue+""+DoubleValue.GetType());

            bool BooleanValue = true;
            Console.WriteLine("Boolean Value = "+BooleanValue+""+BooleanValue.GetType());

            char CharValue = '7';
            Console.WriteLine("Charter Value = "+CharValue+""+CharValue.GetType());

            //Explicit Type

            long LnValue = 123456789;
            int InValue = (int)LnValue;
            Console.WriteLine("IntegerValue = "+InValue+""+InValue.GetType());

            // ushort UshortValue = (ushort)IntValue;
            // Console.WriteLine("UShort Value = "+UshortValue+""+UshortValue.GetType());

            // decimal DecimalValue = (decimal)DoubleValue;
            // Console.WriteLine("Decimal Value = "+DecimalValue+""+DecimalValue.GetType());

        }
    }
}