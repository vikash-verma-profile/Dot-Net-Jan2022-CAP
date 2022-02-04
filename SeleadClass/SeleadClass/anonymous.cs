using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{

    //anonymous types
    class anonymous
    {
        static public void sampleMethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.S_name);
            Console.WriteLine(val.langauge);
            Console.WriteLine(val.nested_ob.email);
        }
        public static void print(int s)
        {

        }
        public static void Main7()
        {

            var anony_Object = new
            {
                s_id = 123,
                S_name = "Vikash verma",
                langauge = "English",
                nested_ob = new {email="Sample@yahoo.com"}
            };
            sampleMethod(anony_Object);
            //print(anony_Object.nested_ob);
        }
    }
}
