using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Youtube
{
    internal class Subscriber
    {
        public string SubscriberName { get; set; }
        //Subscriber()
        //{
        //SubscriberName = 
        //}    
       public void Notify(Video video, Channel channel)
        {
            Console.WriteLine($"New Video Has been Added ! , {SubscriberName}\n{video.Title}: {video.Describtion} from {channel.ChannelName}\n");
        }
        public override string ToString()
        {
            return $"Subscriber Name: {SubscriberName}";
        }


    }
}
