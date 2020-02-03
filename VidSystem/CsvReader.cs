using System;
using System.Collections.Generic;
using System.IO;

namespace VidSystem
{
    class CsvReader
    {

        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Video[] ReadAllVideos(int nVideos)
        {
            Video[] videos = new Video[nVideos];


            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                var index = 0;

                while(index < nVideos)
                {
                    var csvLine = sr.ReadLine();
                    videos[index] = ReadVideoFromCsvLine(csvLine);
                    index++;
                }

            }

                return videos;
        }

        public List<Video> ReadAllVideos()
        {
            List<Video> videos = new List<Video>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
     
                string csvLine;

                while((csvLine = sr.ReadLine()) != null)
                {
                    videos.Add(ReadVideoFromCsvLine(csvLine));

                }

            }

            return videos;
        }

        public Video ReadVideoFromCsvLine(string csvLine)
        {

            string[] parts = csvLine.Split(',');

            string name;
            string type;
            string description;
            string filepath;


            switch(parts.Length)
            {
                case 4:
                    name = parts[0];
                    type = parts[1];
                    description = parts[2];
                    filepath = parts[3];
                    break;

                default:
                    throw new Exception($"Cannot parse video from csvline: { csvLine }");                
            }

            return new Video(name, type, description, filepath);



        }
   }

}
