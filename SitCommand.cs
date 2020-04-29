using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class SitCommand : ICommand
    {
        Dog dog;
        State previousState;
        public SitCommand(Dog d)
        {
            dog = d;
        }
        public void Execute()
        {
            previousState = dog.state;
            dog.state = State.Sit;
        }

        public void Undo()
        {
            dog.state = previousState;
        }
    }
}
