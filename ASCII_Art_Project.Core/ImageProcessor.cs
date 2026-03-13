using NLog;

namespace ASCII_Art_Project.Core
{
    public static class ImageProcessor
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// Processes an image file and returns its character representations in both reversed and normal order.
        /// </summary>
        /// <param name="filePath"> The path to the image file to be processed. </param>
        /// <param name="counter"> The number used to name the output text file. </param>
        /// <returns> A tuple containing two character matrices: the reversed representation and the normal representation of the processed image. </returns>
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
