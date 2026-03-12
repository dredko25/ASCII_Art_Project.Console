using System;
using ASCII_Art_Project.Core;
using NLog;
using System.Windows.Forms;


namespace ASCII_Art_Project
{
    public class Program
    {
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// The entry point of the application that allows the user to select an image file, converts it to ASCII art, and saves the result to a text file. 
        /// </summary>
        /// <param name="args"> A string array that represents the command-line arguments. In this case, it is not used. </param>
        [STAThread]
        static void Main(string[] args)
        {
            byte counter = 0;

            do
            {
                var fileName = ImageFileSelector.SelectImageFile();
                if (fileName == null)
                {
                    Logger.Warn("No file selected.");
                    continue;
                }

                counter++;

                Logger.Info($"Selected file: {fileName}");

                Console.Clear();

                var (reversed, normal) = fileName.ProcessSingleImage(counter);

                foreach (var row in normal)
                    Console.WriteLine(row);

                Console.WriteLine("Press enter to add new image. \n");
                Console.ReadLine();

            } while (true);
        }
    }
}
