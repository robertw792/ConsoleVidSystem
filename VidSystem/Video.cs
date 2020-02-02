namespace VidSystem
{
    class Video
    {
       
        public string Name { get; }
        public string Type { get; }
        public string Description { get; }
        public string FilePath { get; }

        public Video(string name, string type, string description, string filePath)
        {
            Name = name;
            Type = type;
            Description = description;
            FilePath = filePath;
        }
    }
}
