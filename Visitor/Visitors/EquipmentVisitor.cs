namespace Visitor
{
    public abstract class EquipmentVisitor
    {
        public abstract void VisitFloppyDisk(FloppyDisk floppyDisk);
        public abstract void VisitCard(Card card);
        public abstract void VisitChassis(Chassis chassis);
        public abstract void VisitBus(Bus bus);
    }
}