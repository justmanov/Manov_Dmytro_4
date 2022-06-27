using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class PC : IGadget
    {
        public string _name { get; set; }

        public int _cost { get; set; }

        public bool _recharge { get; set; }
        public PC(Monitor monitor, SystemUnit unit)
        {
            _cost = monitor._cost + unit._cost;
            
        }
        public void Print()
        {
            Console.WriteLine($"Цена комп'ютера {_cost}");
        }
        public void Recharge()
        {
            Console.WriteLine("recharge ");
            _recharge = false;
            Console.WriteLine($"recharging {_recharge} ");
            _recharge = true;
            Console.WriteLine($"recharging {_recharge} ");
            Console.WriteLine("done ");
        }
    }
}
