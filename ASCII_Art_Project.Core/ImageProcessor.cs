using NLog;
using System;

namespace ASCII_Art_Project.Core
{
    public static class ImageProcessor
    {
        /// <summary>
        /// Processes an image file and returns its character representations in both reversed and normal order.
        /// </summary>
        /// <param name="filePath"> The path to the image file to be processed. </param>
        /// <returns> A tuple containing two character matrices: the reversed representation and the normal representation of the processed image. </returns>
        public static (char[][] Reversed, char[][] Normal) ProcessSingleImage(this string filePath)
        {
            var result = filePath.ProcessImage();

            string fileName = $"image_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";

            result.Reversed.SaveAsTextFile(fileName);

            return result;
        }
    }
}
