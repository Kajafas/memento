using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    //photo , snapshot
    internal class Memento : IMemento
    {
        //How protected the envelope is .
        private string _state;
        //metadata behind photo
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
