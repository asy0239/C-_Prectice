using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomer mc = new MyCustomer();

            mc.Age = 10;
            mc.Name = "안성윤";

            Console.WriteLine(mc.GetCustomerData());
        }
    }
}
