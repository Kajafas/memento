using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    internal interface IMemento
    {
        public DateTime Time { get; set; }
    }
}
