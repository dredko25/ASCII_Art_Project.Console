using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Art_Project.WinForms
{
    public partial class AsciiArtForm : Form
    {
        public AsciiArtForm(char[][] asciiArt)
        {
            InitializeComponent();
            DisplayAsciiArt(asciiArt);
        }


        /// <summary>
        /// Displays the specified ASCII art in the rich text box.
        /// </summary>
        /// <param name="asciiArt"> A two-dimensional array of characters representing the ASCII art to display. </param>
        private void DisplayAsciiArt(char[][] asciiArt)
        {
            richTextBox.Text = string.Join(Environment.NewLine,
                asciiArt.Select(row => new string(row)));
        }
    }
}
