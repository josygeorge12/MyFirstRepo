using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesTypes
{
    partial class Sample
    {
        public void M1() { }
    }
    partial class Sample
    {
        public void M2() { }
        public void M3() { }
    }
    partial class Sample
    {
        public void M4() { }
        public void M5() { }
    }

    class PartialClass
    {
        static void Main()
        {
            Sample obj = new Sample();
            obj.M1();
            obj.M2();
            obj.M3();
            obj.M4();
            obj.M5();
            //at runtime all classes are merged into one
        }
    }
}
