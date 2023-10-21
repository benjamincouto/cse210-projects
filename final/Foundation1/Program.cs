using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        //Video 1
        Video video1 = new Video("Exploring the Wilderness", "NatureExplorer123", 600);
        video1.StoreComment("User16456", "Great video!");
        video1.StoreComment("User2234", "I learned a lot.");
        video1.StoreComment("User85676", "Wow! This is incredible");
        video1.StoreComment("User453", "This looks fake");
        videos.Add(video1);
        

        //Video 2
        Video video2 = new Video("Cooking Masterclass: Italian Cuisine", "ChefElena", 660);
        video1.StoreComment("User235", "I will try it!");
        video1.StoreComment("User634", "I always learn a lot with your videos");
        video1.StoreComment("User234", "ChefElena, you are great!");
        video1.StoreComment("User555", "Thank you!");
        videos.Add(video2);

        //Video 3
        Video video3 = new Video("The Art of Photography: Capturing Moments", "PhotoEnthusiast", 400);
        video3.StoreComment("User165", "Great video!");
        video3.StoreComment("User233", "I learned a lot.");
        video3.StoreComment("User17", "I'm inspired to start photography!");
        video3.StoreComment("User18", "Your tips are really helpful for beginners.");
        video3.StoreComment("User19", "I appreciate your passion for photography!");
        videos.Add(video3);

        //Video 4
        Video video4 = new Video("Science and Space: The Wonders of the Universe", "AstroExplorer", 550);
        video4.StoreComment("User198", "Great video!");
        video4.StoreComment("User277", "I learned a lot.");
        video4.StoreComment("User20", "Mind-blowing facts about the universe!");
        video4.StoreComment("User21", "I love exploring the mysteries of space.");
        video4.StoreComment("User22", "Can you make a video about black holes?");
        videos.Add(video4);
        

        //iterate through videos list

        foreach (Video video in videos)
        {
            video.DisplayInfo();            
        }
    }
}