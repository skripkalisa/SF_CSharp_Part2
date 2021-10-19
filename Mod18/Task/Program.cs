using System;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            DirectoryInfo currentDir = new DirectoryInfo(".");
            DirectoryInfo projectDir = currentDir.Parent?.Parent?.Parent;
            DirectoryInfo videoDir = projectDir?.CreateSubdirectory("YT videos");
            
            string videoUrl = GetVideoUrl();
            if (videoUrl == "")
            {
                videoUrl = "https://www.youtube.com/watch?v=_-qHL4mqhbI";
            }
            
            var youtube = new YoutubeClient();

            try
            {
                var video = await youtube.Videos.GetAsync(videoUrl);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                // Get highest quality muxed stream
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
// Download the stream to a file
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{videoDir}/{video.Title}.{streamInfo.Container}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static string GetVideoUrl()
        {
            Console.WriteLine("Enter YouTube video link: ");
            string url = Console.ReadLine();
            if(url != null && (url.Contains("youtube") || url.Contains("youtu.be")))
            {
                return url;
            }

            return "https://www.youtube.com/watch?v=_-qHL4mqhbI";
        }
    }
}