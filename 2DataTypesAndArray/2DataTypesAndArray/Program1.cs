using System;


namespace _2DataTypesAndArray
{
    class Demo{
        public void sum()
        {
            Console.WriteLine(10);
        }
    }
    //Value type
    //reference type
    class Program1
    {


        //demoObj.sum();

        static void Main1(string[] args)
        {
            //Program obj = new Program();
            ////class name objectname = new operator then we have class name()
            //int a = 20, b = 10;
            //Console.WriteLine("before swap a=:" + a + " b=" + b);
            //Swap(ref a, ref b);
            //Console.WriteLine("after swap a=:" + a + " b=" + b);

            Demo demoObj = new Demo();
            object object1;
            int a = 5;

            //datatype [] name of the vartiable
            int[] cnumbers= { 10,20,30,40};
            string[] caa;
            string samplename = "vikash";
            int[,] samplearray = new int[2,2]{  { 1,2},{ 3,4} };
        
            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.Write(samplearray[i,j]+"\t");

                }
                Console.WriteLine();
            }

            for (int i = 0; i < samplename.Length; i++)
            {
                Console.WriteLine(samplename[i]);
            }

            for (int i = 0; i < cnumbers.Length; i++)
            {
                Console.WriteLine(cnumbers[i]);
            }

            //boxing
            object1 = (object)a;

            //unboxing
            a = (int)object1;
            Console.WriteLine(object1);
        }

        ////Access specifier, return type ,name of the function
        ////passing arguments
        //static public void Swap(ref int a , ref int b )
        //{
        //    int c = a;
        //    a = b;
        //    b = c;
        //    Console.WriteLine("Values of a and b in Swap function a=:" + a + " b="+b);
        //}
    }
}
