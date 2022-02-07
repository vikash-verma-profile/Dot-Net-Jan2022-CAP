using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }

    public class TestTemprature
    {
        int temperature = 0;
        public void ShowTemperature()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature :{0}", temperature);
            }
        }
        static void Main(string[] args)
        {
            TestTemprature testTemprature = new TestTemprature();
            try
            {
                testTemprature.ShowTemperature();
            }
            catch (TempIsZeroException ex)
            {
                Console.WriteLine("Custom execption is {0}", ex.Message); 
            }
        }
    }
}
