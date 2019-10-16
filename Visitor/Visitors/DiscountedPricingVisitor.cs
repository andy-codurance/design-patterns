namespace Visitor
{
    public class DiscountedPricingVisitor : EquipmentVisitor
    {
        private int total;
        
        public override void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            total += floppyDisk.DiscountPrice();
        }

        public override void VisitCard(Card card)
        {
            total += card.DiscountPrice();
        }

        public override void VisitChassis(Chassis chassis)
        {
            total += chassis.DiscountPrice();
        }

        public override void VisitBus(Bus bus)
        {
            total += bus.DiscountPrice();
        }

        public int GetTotal()
        {
            return total;
        }
    }
}