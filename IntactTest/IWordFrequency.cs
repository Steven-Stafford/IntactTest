using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntactTest
{
    public interface IWordFrequency
    {
        string word { get; set; }
        int frequency { get; set; }
    }
}
