using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var chassis = new Chassis();
            chassis.Add(new FloppyDisk());
            chassis.Add(new Card("Vodoo FX"));
            chassis.Add(new Bus("AGP"));

            var pricingVisitor = new PricingVisitor();
            chassis.Accept(pricingVisitor);
            Console.WriteLine($"The system build will cost £{pricingVisitor.GetTotal()}");
            
            var discountedPricingVisitor = new DiscountedPricingVisitor();
            chassis.Accept(discountedPricingVisitor);
            Console.WriteLine($"The discounted system build will cost £{discountedPricingVisitor.GetTotal()}");
        }
    }
}