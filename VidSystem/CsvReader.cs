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

        public Video ReadVideoFromCsvLine(string csvLine)
        {

            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string type = parts[1];
            string description = parts[2];
            string filepath = parts[3];

            return new Video(name, type, description, filepath);



        }
   }

}
