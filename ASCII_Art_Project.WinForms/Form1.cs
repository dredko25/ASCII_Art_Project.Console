using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCII_Art_Project.Core;
using NLog;

namespace ASCII_Art_Project.WinForms
{
    public partial class Form1 : Form
    {
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();


        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles the click event for the Console button, launching the ASCII Art Project console application.
        /// </summary>
        /// <param name="sender"> The source of the event. </param>
        /// <param name="e"> The event data associated with the button click. </param>
        private void buttonConsole_Click(object sender, EventArgs e)
        {
            try
            {
                string consoleAppPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ASCII_Art_Project.Console.exe");
                ProcessStartInfo processStartInfo = new ProcessStartInfo(consoleAppPath);

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        /// <summary>
        /// Handles the click event for the Forms button, allowing the user to select an image file and display its ASCII art representation in a new form.
        /// </summary>
        /// <param name="sender"> The source of the event. </param>
        /// <param name="e"> The event data associated with the button click. </param>
        private void buttonForms_Click(object sender, EventArgs e)
        {
            Logger.Info("Starting the WinForms application.");
            var fileName = ImageFileSelector.SelectImageFile();
            if (fileName == null)
            {
                Logger.Warn("No file selected.");
                return;
            }

            Logger.Info($"Selected file: {fileName}");

            var (reversed, normal) = fileName.ProcessSingleImage();

            var form = new AsciiArtForm(normal);
            form.Show();
        }
    }
}
