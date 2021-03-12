using System;
using System.Diagnostics;

namespace ForVsForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] arr = new string[,,] {
                { { "1","2"},{ "11","22"} },
                { {"3","4" },{"33","44" } }
            };
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i  = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Debug.WriteLine(arr[i,j,k]);
                    }
                }
            }

            stopwatch.Stop();
            Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds + "ms");

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            foreach(var s in arr)
            {
                Debug.WriteLine(s);
            }
            stopwatch1.Stop();
            Console.WriteLine("time : " + stopwatch1.ElapsedMilliseconds + "ms");
        }
    }
}
