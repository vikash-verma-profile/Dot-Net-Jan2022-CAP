using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpts
{
    //constructor

    public class SampleC
    {
        //fields or data members of this class
        //Type of constructors
        //1.Default
        //2.Parametrized
        //3.Static Costructor
        //4.private constructor
        //5.Copy constructor
        int a, b;
        //Default Constructor
        public SampleC()
        {

        }
        ~SampleC()
        {

        }
        //parametrized constructor
        public SampleC(int _a,int _b)
        {
            a = _a;
            b = _b;
        }

    }
    class ConstructorVsDestructor
    {
        static void Main2(string[] args)
        {
            SampleC ObjSampleC = new SampleC();
            Console.ReadLine();
        }
    }
}
