using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();


        foreach (Video video in videosList)
        {
            video.DisplayInfo();
        }
    }
}

