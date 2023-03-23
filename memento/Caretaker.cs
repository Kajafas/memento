using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    //Coordinator
    internal class Caretaker
    {
        //Stacks which hold photos
        private readonly Stack<Memento> _undostack = new Stack<Memento>();
        private readonly Stack<Memento> _redostack = new Stack<Memento>();
        //person to coordinate
        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }
        //receives photo and puts it to stack
        public void Save()
        {
            var memento = _originator.SaveState();
            _undostack.Push(memento);
            //_redostack.Clear();
        }
        //gives the first photo from undo stack
        public void Undo()
        {
            if (_undostack.Count > 0)
            {
                var memento = _undostack.Pop();
                _redostack.Push(_originator.SaveState());
                _originator.RestoreState(memento);

            }
        }
        //gives the first photo from redo stack

        public void Redo()
        {
            if ( _redostack.Count > 0)
            {
                var memento = _redostack.Pop();
                _undostack.Push(_originator.SaveState());
                _originator.RestoreState(memento);
            }
        }
    }
}
