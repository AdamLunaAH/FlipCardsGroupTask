using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCards
{
    internal class Flashcard : IFlaschcard
    {


        public string Title { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Answer { get; set; }


        public Flashcard(string title, string question, string option1, string option2, string option3, string answer)
        {
            Title = title;
            Question = question;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Answer = answer;
        }

    }
}
