using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    enum State {LayDown, Sit, Voice}
    class Dog
    {
        public State state { get; set; } = State.Sit;

    }
}
