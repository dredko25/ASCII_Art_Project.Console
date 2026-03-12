using NLog;

namespace ASCII_Art_Project.Core
{
    public static class ImageProcessor
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static (char[][] Reversed, char[][] Normal) ProcessSingleImage(this string filePath, int counter)
        {
            Logger.Info($"Selected file: {filePath}");

            var result = filePath.ProcessImage();

            result.Reversed.SaveAsTextFile($"image{counter}.txt");

            Logger.Info($"User added {counter} images");

            return result;
        }
        
    }
}
