using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using ASCII_Art_Project.Core;

namespace ASCII_Art_Project.UnitTests
{
    [TestClass]
    public class BitmapToASCIIConverterTests
    {
        [TestMethod]
        public void Map_ValueIsMapped_ReturnsMappedValue()
        {
            // Arrange
            var converter = new BitmapToASCIIConverter(null);
            float value = 128;
            float fromSource = 0;
            float toSource = 255;
            float fromTarget = 0;
            float toTarget = 9;
            // Act
            byte result = (byte)converter.Map(value, fromSource, toSource, fromTarget, toTarget);
            // Assert
            Assert.AreEqual(4, result);
        }


        [TestMethod]
        public void Reverse_ValueIsReversed_ReturnsReversedValue()
        {
            // Arrange
            var converter = new BitmapToASCIIConverter(null);
            char[] testArray = { 'a', 'b', 'c', 'd', 'e' };
            char[] expectedReversedArray = { 'e', 'd', 'c', 'b', 'a' };
            // Act
            char[] result = converter.Reverse(testArray);
            // Assert
            CollectionAssert.AreEqual(expectedReversedArray, result);
        }


        [TestMethod]
        public void Convert_BlackPixel_MapsToFirstCharInAsciiTable()
        {
            // Arrange
            char[] asciiTable = new char[] { '@', '#', ' ', '.' };
            var bitmap = new Bitmap(1, 1);
            bitmap.SetPixel(0, 0, Color.FromArgb(0, 0, 0));
            var converter = new BitmapToASCIIConverter(bitmap);
            // Act
            var result = converter.Convert(asciiTable);
            // Assert
            Assert.AreEqual('@', result[0][0]);
        }


        /* IntegrationTest */
        [TestMethod]
        public void Convert_ConvertPixsels_ReturnsExpectedCharacters()
        {
            // Arrange
            var bitmap = new Bitmap(2, 1);
            bitmap.SetPixel(0, 0, Color.FromArgb(0, 0, 0));
            bitmap.SetPixel(1, 0, Color.FromArgb(255, 255, 255));
            char[] asciiTable = { '#', '.' };
            var converter = new BitmapToASCIIConverter(bitmap);
            // Act
            char[][] result = converter.Convert(asciiTable);
            // Assert
            Assert.AreEqual('#', result[0][0]);
            Assert.AreEqual('.', result[0][1]);
        }
    }
}
