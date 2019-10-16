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

            var pricingVisitor = new PricingVisitor();
            chasis.Accept(pricingVisitor);
            Console.WriteLine($"The system build will cost £{pricingVisitor.GetTotal()}");
            
            var discountedPricingVisitor = new DiscountedPricingVisitor();
            chasis.Accept(discountedPricingVisitor);
            Console.WriteLine($"The discounted system build will cost £{discountedPricingVisitor.GetTotal()}");
        }
    }
}