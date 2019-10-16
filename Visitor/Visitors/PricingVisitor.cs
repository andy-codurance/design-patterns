namespace Visitor
{
    public class PricingVisitor : EquipmentVisitor
    {
        private int total;
        
        public override void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            total += floppyDisk.NetPrice();
        }

        public override void VisitCard(Card card)
        {
            total += card.NetPrice();
        }

        public override void VisitChassis(Chassis chassis)
        {
            total += chassis.NetPrice();
        }

        public override void VisitBus(Bus bus)
        {
            total += bus.NetPrice();
        }

        public int GetTotal()
        {
            return total;
        }
    }
}