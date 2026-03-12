using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Art_Project.Core
{
    public static class ImageFileSelector
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static string SelectImageFile()
        {
            Logger.Info("Starting the application.");

            OpenFileDialog openFileDilog = new OpenFileDialog
            {
                Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"
            };

            return openFileDilog.ShowDialog() == DialogResult.OK ? openFileDilog.FileName : null;
        }
    }
}
