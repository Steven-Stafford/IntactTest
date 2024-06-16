using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntactTest
{
    public interface IWordFrequency
    {
        string Word { get; set; }
        int Frequency { get; set; }
    }
}
