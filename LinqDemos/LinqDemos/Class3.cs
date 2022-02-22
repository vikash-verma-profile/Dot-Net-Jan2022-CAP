using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
    //oftype
    class Class3
    {
        static void Main3()
        {
            IList sampleList = new ArrayList();
            sampleList.Add(0);
            sampleList.Add("One");
            sampleList.Add("Two");
            sampleList.Add(3);
            sampleList.Add(new Student() { StudentId = 1, StudentName = "Vikash" });

            var stringResult = from s in sampleList.OfType<string>() select s;
            var intResult = from s in sampleList.OfType<int>() select s;
            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }
            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }

        }
    }
}
