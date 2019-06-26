using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            new Abstraction(new ConcreteImplementationA()).Operation();
            new Abstraction(new ConcreteImplementationB()).Operation();
        }
    }

    class Abstraction
    {
        private Implementor imp;

        public Abstraction(Implementor imp) => this.imp = imp;

        public void Operation() => imp.OperationImp();
    }

    abstract class Implementor
    {
        public abstract void OperationImp();
    }

    class ConcreteImplementationA : Implementor
    {
        public override void OperationImp() => throw new NotImplementedException();
    }
    
    class ConcreteImplementationB : Implementor
    {
        public override void OperationImp() => throw new NotImplementedException();
    }
}