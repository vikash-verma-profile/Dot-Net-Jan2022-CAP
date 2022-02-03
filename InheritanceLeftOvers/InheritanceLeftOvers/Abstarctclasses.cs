using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLeftOvers
{
    abstract class SampleA
    {
       public SampleA()
        {

        }

        abstract public void show();
       
    }
    class SampleB:SampleA
    {
        public SampleB()
        {

        }
        //overriding
        public override void show()
        {

        }
    }
    class Abstarctclasses
    {
        static void Main3(string[] args)
        {
            SampleB b = new SampleB();
        }   
    }
}
