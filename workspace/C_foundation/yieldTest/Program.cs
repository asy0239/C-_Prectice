using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace yieldTest
{
    public class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        
        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
                Thread.Sleep(500);
            }

            // using the foreach
            var list = new MyList();
            
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            // Manual Iteration 
            IEnumerator it = list.GetEnumerator();


            it.MoveNext();
            Console.WriteLine(it.Current);
            it.MoveNext();
            it.MoveNext();
            Console.WriteLine(it.Current);
            
            
            

        }

        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }
    }
}
