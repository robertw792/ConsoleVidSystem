using System;

namespace VidSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\rob\Documents\Vidsystem.csv";

            var reader = new CsvReader(filePath);

            Video[] videos = reader.ReadAllVideos(2);

            foreach(Video video in videos)
            {
                Console.WriteLine($"{video.Name}: {video.Description}, {video.Type}, {video.FilePath}");
                Console.ReadKey();
            }

        }
    }
}
