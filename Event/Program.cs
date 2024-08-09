using Event.Fifa_Game;
using Event.Youtube;
using System.Collections;
using System.Net.WebSockets;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fifa Game
            //Ball ball = new Ball() { Id = 1};
            //Console.WriteLine(ball);

            //Player P01 = new Player() { PlayerName = "Messi",TeamName="Miani"};
            //Player P02 = new Player() { PlayerName = "Alba", TeamName = "Miani" };

            //Player P03 = new Player() { PlayerName = "Pedri", TeamName = "Barcelona" };
            //Player P04 = new Player() { PlayerName = "Gvi", TeamName = "Barcelona" };

            //Player P05 = new Player() { PlayerName = "Salah Mohsen", TeamName = "Barcelona" };


            //Refree R01 = new Refree() { RefreeName = "Ibrahmi Nour El-Din" };

            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            //ball.BallLocationChanged += P01.Run;
            //ball.BallLocationChanged += P02.Run;
            //ball.BallLocationChanged += P03.Run;
            //ball.BallLocationChanged += P04.Run;
            //ball.BallLocationChanged += R01.Look;


            //ball.Location = new Location() { X = 2, Y = 8, Z = 3 };


            //Console.WriteLine("\nAfter replace Pedri with Salah\n");
            //ball.BallLocationChanged -= P03.Run;
            //ball.BallLocationChanged += P05.Run;



            //ball.Location = new Location() { X = 8, Y = 8, Z = 3 };
            #endregion

            #region Youtube
            Channel channel = new Channel() { ChannelName = "ABC"};
            //channel.AddVideo(new Video() {Title= "Title01",Describtion="Desc01" });
            Subscriber subscriber01 = new Subscriber() {SubscriberName = "s1" };
            Subscriber subscriber02 = new Subscriber() { SubscriberName = "s2" };
            Subscriber subscriber03 = new Subscriber() { SubscriberName = "s3" };
            Subscriber subscriber04 = new Subscriber() { SubscriberName = "s4" };
            Subscriber subscriber05 = new Subscriber() { SubscriberName = "s5" };
            Subscriber subscriber06 = new Subscriber() { SubscriberName = "s6" };

            channel.UploadVideo += subscriber01.Notify;
            channel.UploadVideo += subscriber02.Notify;
            channel.UploadVideo += subscriber03.Notify;
            channel.UploadVideo += subscriber04.Notify;
            channel.UploadVideo += subscriber05.Notify;
            //channel.UploadVideo += subscriber06.Notify;


            channel.AddVideo(new Video() { Title = "Title01", Describtion = "Desc01" });
            Console.WriteLine();
            channel.AddVideo(new Video() { Title = "Title02", Describtion = "Desc02" });

            #endregion

            #region Hashtable\Dictionary
            //Hashtable Note = new Hashtable();
            //Console.WriteLine($"Count: {Note.Count}");
            //Note.Add(key:"Noura",value:111111111);
            //Note.Add(key:"Aliaa",value:222222222);
            //Note.Add(key:"Hala",value:333333333);
            //Note.Add(key:"Mai",value:444444444);
            //Console.WriteLine($"Count: {Note.Count}");
            //foreach (object note in Note.Values)
            //    Console.WriteLine(note);

            //Dictionary<string, long> Note = new Dictionary<string, long>();
            //Note.Add(key: "Noura", value:11111111);
            //Note.Add(key: "Aliaa", value: 444444444);
            //Note.Add(key: "Hala", value: 222222222);
            //Note.Add(key: "Mai", value: 333333333);
            //foreach (KeyValuePair<string,long> note in Note)
            //    Console.WriteLine($"Key: {note.Key}, Value: {note.Value}");


            #endregion



        }
    }
}
