using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    internal class Memento : IMemento
    {
        private string _state;

        public DateTime Time { get; set; }

        public string GetState()
        {
            return _state;
        }
        public Memento (string state)
        {
            Time = DateTime.Now;
            _state = state;
        }
    }
}
