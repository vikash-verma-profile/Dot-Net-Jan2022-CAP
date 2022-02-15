using System;
using System.IO;
using Calculator;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HandlingLibrabries
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Calculate cal = new Calculate();

            using (StreamReader r = new StreamReader("C://Users//svdsk25//Desktop//sample.json"))
            {
                string json = r.ReadToEnd();
                Book items = JsonConvert.DeserializeObject<Book>(json);
                Console.WriteLine(items.BookAuthor);
                Console.WriteLine(items.BookName);
            }

            Book book = new Book();
            book.BookName = "Hello";
            book.BookAuthor = "Hi";
            string json1 = JsonConvert.SerializeObject(book);
            System.IO.File.WriteAllText("C://Users//svdsk25//Desktop//new.json", json1);
        }
    }
}
