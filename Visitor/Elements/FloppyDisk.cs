namespace Visitor
{
    public class FloppyDisk : Equipment
    {
        private string name = "Floppy";

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitFloppyDisk(this);
        }

        public override string Name()
        {
            return name;
        }
        public override int NetPrice()
        {
            return 20;
        }
        public override int DiscountPrice()
        {
            return 10;
        }
    }
}