using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    internal class Caretaker
    {
        private readonly Stack<Memento> _undostack = new Stack<Memento>();
        private readonly Stack<Memento> _redostack = new Stack<Memento>();
        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }
        public void Save()
        {
            var memento = _originator.SaveState();
            _undostack.Push(memento);
            //_redostack.Clear();
        }
        public void Undo()
        {
            if (_undostack.Count > 0)
            {
                var memento = _undostack.Pop();
                _redostack.Push(_originator.SaveState());
                _originator.RestoreState(memento);

            }
        }
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
