using System;
using System.Collections.Generic;

namespace VidSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"N:\Repos\robertw792\ConsoleVidSystem\VidSystem\Vidsystem.csv";

            var reader = new CsvReader(filePath);

            List<Video> videos = reader.ReadAllVideos();

            foreach(Video video in videos)
            {
                Console.WriteLine($"{video.Name}, {video.Description}, {video.Type}, {video.FilePath}");
            }

            Console.WriteLine($" No of vids is : {videos.Count}");


        }
    }
}
