using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    //Me
    internal class Originator
    {
        //outfit
        private string _state;
        //trying clothes
        public void SetState(string state)
        {
            _state = state;
        }
        public void ShowState()
        {
            Console.WriteLine("The state is "+ _state);
        }
        //selfie photo
        public Memento SaveState()
        {
            return new Memento(_state);
        }
        //dress depending on photo
        public void RestoreState(Memento memento)
        {
            _state = memento.GetState();
        }
    }
}
