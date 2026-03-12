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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void buttonForms_Click(object sender, EventArgs e)
        {
            byte counter = 0;

            var fileName = ImageFileSelector.SelectImageFile();
            if (fileName == null)
            {
                Logger.Warn("No file selected.");
                return;
            }

            counter++;

            Logger.Info($"Selected file: {fileName}");

            var (reversed, normal) = fileName.ProcessSingleImage(counter);

            var form = new AsciiArtForm(normal);
            form.Show();
        }
    }
}
