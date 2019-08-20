namespace Memento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Caretaker
    {
        static void Main(string[] args)
        {
            // Implementation example from GOF book, pg 287
            var mementoes = new List<Originator.Memento>();
            
            var originator = new Originator();
            Console.WriteLine("Initial state:");
            originator.Print();
            
            mementoes.Add(originator.CreateMemento());
            originator.Update();
            Console.WriteLine($"State @ {DateTime.Now}:");
            originator.Print();
            
            originator.SetMemento(mementoes.Last());
            Console.WriteLine("Restored initial state:");
            originator.Print();

            Console.ReadLine();
        }
    }

    class Originator
    {
        private string state;

        public Originator()
        {
            Update();
        }

        public void Update()
        {
            state = Guid.NewGuid().ToString();
        }

        public void Print()
        {
            Console.WriteLine(state);
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            state = ((IMemento) memento).State;
        }

        // HACK - Memento should not expose state outside of the Originator
        // this is possible with C++ and Java without using a private interface
        private interface IMemento
        {
            string State { get; set; }
        }
        
        internal class Memento : IMemento
        {
            private string state;

            public Memento(string state)
            {
                this.state = state;
            }

            string IMemento.State
            {
                get => state;
                set => state = value;
            }
        }
    }
}
