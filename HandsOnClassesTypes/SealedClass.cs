using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesTypes
{
    class A
    {
        public void M() { }
    }
    //sealed class cannot be inherited
    sealed class B : A
    {
        public void M2()
        {

        }
    }
    class C  
    {
        public void M3()
        {

        }
    }
    class SealedClass
    {
        static void Main()
        {

        }
    }
}
