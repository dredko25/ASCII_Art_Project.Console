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

        private void DisplayAsciiArt(char[][] asciiArt)
        {
            richTextBox.Text = string.Join(Environment.NewLine,
                asciiArt.Select(row => new string(row)));
        }
    }
}
