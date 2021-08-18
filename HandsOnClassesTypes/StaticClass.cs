using System;

namespace HandsOnClassesTypes
{
    static class Converter
    {
        public static double RTD(double rupess)
        {
            return rupess / 78.5;
        }
        public static double DTR(double dollers)
        {
            return dollers * 78.5;
        }
    }
    
     class StaticClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:C}",Converter.RTD(10000));
        }
    }
}
