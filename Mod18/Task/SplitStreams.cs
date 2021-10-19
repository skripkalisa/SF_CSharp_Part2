using System.Linq;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Task
{
    public class SplitStreams
    {
        private static async void  GetYtData(string videoUrl)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(videoUrl);
            string videoId = video.Id;
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);

            var audioStreamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
            var videoStreamInfo = streamManifest
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();
            var streamInfos = new[] { audioStreamInfo, videoStreamInfo };

// Download and process them into one file
            await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder($"../../../yt_{video.Title}.mp4").Build());
        }
    }
}