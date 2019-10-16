using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var chasis = new Chassis();
            chasis.Add(new FloppyDisk());
            chasis.Add(new Card("Vodoo FX"));
            chasis.Add(new Bus("AGP"));

            var equipmentVisitor = new PricingVisitor();
            chasis.Accept(equipmentVisitor);
            Console.WriteLine($"The system build will cost £{equipmentVisitor.GetTotal()}");
        }
    }
}