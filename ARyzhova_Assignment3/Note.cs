using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARyzhova_Assignment3
{
    public class Note
    {
        public string Text;
        public DateTime DateAndTime;

        public Note(string text)
        {
            this.Text = text;
            DateAndTime = DateTime.Now;
        }

        internal void AppendToFile(StreamWriter notewr)
        {
            notewr.WriteLine($"{Text}\r\n{DateAndTime}");
        }
    }
}
