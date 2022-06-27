using System;
namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter monitpr cost ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter unit cost ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter smartphone cost ");
            int b = Convert.ToInt32(Console.ReadLine());
            Monitor monitor = new Monitor(n);
            SystemUnit unit = new SystemUnit(a);
            Smartphone smartphone = new Smartphone(b);
            PC pc = new PC(monitor, unit);
            Console.WriteLine("want to conect monitor? 1 - yes, 2 - no");
            string r = Console.ReadLine();
            if (r == "1")
            {
                monitor.Connect();
            }
            else if (r =="2")
                monitor.Disconnect();
            Console.WriteLine("want to conect unit? 1 - yes, 2 - no");
            string r1 = Console.ReadLine();
            if (r1 == "1")
            {
                unit.Connect();
            }
            else if (r1 == "2")
                unit.Disconnect();
            Console.WriteLine("want to conect smartphone? 1 - yes, 2 - no");
            string r2 = Console.ReadLine();
            if (r2 == "1")
            {
                smartphone.Connect();
            }
            else if (r2 == "2")
                smartphone.Disconnect();
            Console.WriteLine("want to recharge monitor? 1 - yes, 2 - no");
            string r3 = Console.ReadLine();
            if (r3 == "1")
            {
               monitor.Recharge();
            }
            Console.WriteLine("want to recharge PC? 1 - yes, 2 - no");
            string r4 = Console.ReadLine();
            if (r4 == "1")
            {
                pc.Recharge();
            }
            Console.WriteLine();
            monitor.Print();
            Console.WriteLine();
            unit.Print();
            Console.WriteLine();
            smartphone.Print();
            Console.WriteLine();
            pc.Print();
            Console.WriteLine();
            monitor.ShowConnection();
            Console.WriteLine();
            unit.ShowConnection();
            Console.WriteLine();
            smartphone.ShowConnection();
        }
    }
}