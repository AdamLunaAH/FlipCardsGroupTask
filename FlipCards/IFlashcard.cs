using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCards
{
    public interface IFlashcard
    {
        string Title { get; set; }
        string Question { get; set; }
        string Option1 { get; set; }
        string Option2 { get; set; }
        string Option3 { get; set; }
        string Answer { get; set; }

    }
}
