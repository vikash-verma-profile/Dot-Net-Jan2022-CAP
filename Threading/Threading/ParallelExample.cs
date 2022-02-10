using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    internal class ParallelExample
    {

        static readonly BlockingCollection<string> collection = new BlockingCollection<string>();
        private static int _count = 0;
        public static void Main()
        {
            const int maxTasks = 5;//we are taking 5 process as an example
            var tasks = new List<Task>
            {
                Task.Factory.StartNew(()=>{
                    for (int i = 0; i < 5; i++)
                    {
                        collection.Add(i.ToString(CultureInfo.InvariantCulture));
                    }
                    Console.WriteLine("Spawing multiple process complted");
                    collection.CompleteAdding();
                }),
             };
            for (int i = 0; i < maxTasks; i++)
            {
                tasks.Add(Task.Factory.StartNew(UserTasks(i)));
            }
            Task.WaitAll(tasks.ToArray()); //Wait for completion
        }

        static Action UserTasks(int id)
        {
            //retun a closure 
            return () =>
            {
                while (true)
                {
                    string item;
                    if(collection.TryTake(out item, -1))
                    {
                        using (Process p=new Process())
                        {
                            p.StartInfo.FileName = "notepad.exe";
                            p.Start();
                            p.WaitForExit();
                            var exitcode = p.ExitCode;
                            Console.WriteLine(exitcode==0?"{0} exited succesfully":"{0} exited failed",p.Id);
                        }
                    }else if (collection.IsAddingCompleted)
                    {
                        break;
                    }
                }
                Console.Write("Consumer {0} finsihed", id);
                _count = _count + 1;
                if (_count == 4)
                {
                    Console.ReadLine();
                }

            };
        }
    }
}
