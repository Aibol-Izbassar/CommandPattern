using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class VoiceCommand:ICommand
    {
        Dog dog;
        State previousState;
        public VoiceCommand(Dog d)
        {
            dog = d;
        }
        public void Execute()
        {
            previousState = dog.state;
            dog.state = State.Voice;
        }

        public void Undo()
        {
            dog.state = previousState;
        }
    }
}
