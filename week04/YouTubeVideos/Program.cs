using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = LoadVideos();
        LoadComments(videos);

        foreach (Video video in videos)
        {
            video.displayVideoInfo();
        }


    }

    static List<Video> LoadVideos()
    {
        return new List<Video>
        {
            new Video("Test video 1", "Ivan Lopez", 123),
            new Video("Test video 2", "Bryan Salgado", 342),
            new Video("Test video 3", "Christian Portillo", 455),
            new Video("Test video 4", "Mahi Hernandez", 45)
        };
    }

    static void LoadComments(List<Video> videos)
    {
        for (int i = 0 ; i < videos.Count() ; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                videos[i].addComment("Anonymous person", "Testing the comments section");
            }
        }
    }
}