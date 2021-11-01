using System.IO;

namespace SocialNetwork.PLL.Helpers
{
    public class AbsolutePath
    {
        public string GetProjectDirectory()
        {
            string path = Directory.GetCurrentDirectory();
            var projectDirectory = Directory.GetParent(path).Parent?.Parent;

            return projectDirectory?.FullName;
        }
    }
}