using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP.WinFormsApp1.Transports
{
    internal class Bus : Trasports
    {
        public Bus(int capacity, string name)
        {
            
            LtsCapacity = capacity;
            Lts = 0;
            Name = name;
            Perfonmance = 8;

            
        }


    }
}
