using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Maui
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Password {  get; set; }
        public bool IsLocked => !string.IsNullOrEmpty(Password);

        public Note() { }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string GetTitle()
        {
            return Title;

        }

        public string GetText()
        {
            return Text;
        }
    }
}
