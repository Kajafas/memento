using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    //Extra info oh photo taken
    internal interface IMemento
    {
        public DateTime Time { get; set; }
    }
}
