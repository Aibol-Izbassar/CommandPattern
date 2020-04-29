using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class LayDownCommand:ICommand
    {
        Dog dog;
        State previousState;
        public LayDownCommand(Dog d)
        {
            dog = d;
        }
        public void Execute()
        {
            previousState = dog.state;
            dog.state = State.LayDown;
        }

        public void Undo()
        {
            dog.state = previousState;
        }
    }
}
