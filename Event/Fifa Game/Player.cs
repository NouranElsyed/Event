using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Fifa_Game
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public void Run() 
        {
            Console.WriteLine($"Player: {PlayerName} is Running .....");
        }
    }
}
