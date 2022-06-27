﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Smartphone : Component
    {
        public override int _cost { get; set; }
        public override string _name { get; set; }
        public override bool _isConnected { get; set; }
        public Smartphone(int cost)
        {
            _cost = cost;
            string name = "Смартфон";
            _name = name;

        }
        public void Connect()
        {
            _isConnected = true;
        }
        public void Disconnect()
        {
            _isConnected = false;
        }
        public void ShowConnection()
        {
            if (_isConnected == true)
            {
                Console.WriteLine($"{_name} connected ");
            }
            else
                Console.WriteLine($"{_name} disconnected ");
        }

        public void Print()
        {
            Console.WriteLine($"Ціна Смартфону {_cost}");
            Console.WriteLine($"Назва {_name}");
        }
    }
}
