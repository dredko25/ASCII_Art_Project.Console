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
        /// <summary>
        /// Displays a file dialog that allows the user to select an image file from the local file system.
        /// </summary>
        /// <returns> The full path of the selected image file if the user confirms the selection. Otherwise, null. </returns>
        public static string SelectImageFile()
        {
            OpenFileDialog openFileDilog = new OpenFileDialog
            {
                Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"
            };

            return openFileDilog.ShowDialog() == DialogResult.OK ? openFileDilog.FileName : null;
        }
    }
}
