using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Fifa_Game
{
    internal class Refree
    {
        public string RefreeName { get; set; }
        public void Look() 
        {
            Console.WriteLine($"Refree: {RefreeName} is Looking At Ball. ");
        }
    }
}
