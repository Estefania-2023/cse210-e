using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();
        // Video 1
        Video video1 = new Video("Living in the Heart of Peru: Exploring Ancient Ruins", "Juan Perez Garcia", 480, 810);

        Comment video1Comment1 = new Comment("Luisa", "This video is truly inspiring! I love how you explore the ancient ruins and share their history.", 5);
        Comment video1Comment2 = new Comment("Carlos", "Your content always surprises me. I'm glad you're showcasing the beauty of our country.", 4);
        Comment video1Comment3 = new Comment("Maria", "Wonderful! I would love to visit those places someday.", 5);

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Hidden Gems of Peru: Uncovering Mysteries in the Andes", "Jhon Mercedes Palomino", 975, 1796);

        Comment video2Comment1 = new Comment("Diego", "What an incredible adventure! I love how you showcase the mysteries of the Andes and invite us to discover more about our history.",3);
        Comment video2Comment2 = new Comment("Valeria", "Your videos always transport me to new places. Thank you for sharing these hidden gems.",6);
        Comment video2Comment3 = new Comment("Camila", "The views are simply breathtaking. I'm proud to be Peruvian.", 5);
        Comment video2Comment4 = new Comment("Roberto", "Interesting video! I'm grateful to see the beautiful places like this.", 7);

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);
        video2.ListComment(video2Comment4);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Peruvian Cuisine: A Gastronomic Adventure", "Miriam Velasquez Soto", 650, 1200);

        Comment video3Comment1 = new Comment("Gabriel", "My mouth was watering while watching this video! Our cuisine is truly unique and delicious.",2);
        Comment video3Comment2 = new Comment("Renata", "I love how you present our traditional dishes. I definitely need to try them all.",3);
        Comment video3Comment3 = new Comment("Fernando", "Peruvian food is famous worldwide, and your videos perfectly capture its essence.",5);

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);


        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

