using ASCII_Art_Project.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace ASCII_Art_Project.UnitTests
{
    [TestClass]
    public class ImageProcessorTests
    {
        [TestMethod]
        public void ProcessSingleImage_ValidPath_ReturnsCorrectMatrices()
        {
            // Arrange
            string testImagePath = "test.jpg";
            using (Bitmap bitmap = new Bitmap(10, 10))
            {
                bitmap.Save(testImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            try
            {
                // Act
                var result = testImagePath.ProcessSingleImage();

                // Assert
                Assert.IsNotNull(result.Normal);
                Assert.IsNotNull(result.Reversed);
                Assert.AreEqual(result.Normal.Length, result.Reversed.Length);
            }
            finally
            {
                if (File.Exists(testImagePath))
                    File.Delete(testImagePath);

                foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory(), "image_*.txt"))
                    File.Delete(file);
            }
        }
    }
}
