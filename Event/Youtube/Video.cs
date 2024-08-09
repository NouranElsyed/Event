using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Youtube
{
    internal class Video
    {
        public string Title { get; set; }
        public string Describtion { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nDescribtion: {Describtion}";
        }

    }
}
