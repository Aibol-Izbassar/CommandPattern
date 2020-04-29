using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Dog d2 = new Dog();
            Tammer t = new Tammer();
            
            ICommand cmd = new VoiceCommand(d);
            t.Invoke(cmd);
            Console.WriteLine(d.state);
            cmd = new LayDownCommand(d);
            t.Invoke(cmd);
            Console.WriteLine(d.state);
            t.Undo();
            Console.WriteLine("previous "+d.state);
            t.Invoke(new LayDownCommand(d2));
            Console.WriteLine("previous "+d2.state);
            t.Undo();
            Console.WriteLine(d2.state);
            Console.WriteLine(d.state);
        }
    }
}
