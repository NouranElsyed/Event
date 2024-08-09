using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Fifa_Game
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;
        public Location Location 
        {
            get { return location; }
            set {
                if (!value.Equals(location))
                {
                    location = value;
                    BallLocationChanged?.Invoke();
                }
            }
        }
        public event Action? BallLocationChanged;
        public override string ToString()
        {
            return $"Id: {Id}, Loction: {Location}";
        }
    }
}
