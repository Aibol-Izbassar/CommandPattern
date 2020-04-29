using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Tammer
    {
        Stack<ICommand> commands = new Stack<ICommand>();
        public void Invoke(ICommand command)
        {
            commands.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            commands.Pop().Undo();
        }
    }
}
