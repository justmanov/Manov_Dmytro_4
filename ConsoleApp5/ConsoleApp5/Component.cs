using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal abstract class Component : IGadget
    {
        public abstract string _name { get; set; }
        public abstract int _cost { get; set; }
        public bool _recharge { get; set; }
        public abstract bool _isConnected { get; set; }

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
