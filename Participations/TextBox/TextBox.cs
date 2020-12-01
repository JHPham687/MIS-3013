using System;
using System.Collections.Generic;
using System.Text;

namespace TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor FrontColor { get; set; }
        public String Text { get; set; }

        public TextBox(int padding, ConsoleColor backcolor, ConsoleColor frontcolor, string text)
        {
            Padding = padding;
            BackColor = backcolor;
            FrontColor = frontcolor;
            Text = text;
        }

        public void DisplayText()
        {
            Console.WriteLine(TextBox);
        }

    }
}
