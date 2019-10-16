namespace Visitor
{
    public class Bus : Equipment
    {
        private readonly string name;

        public Bus(string name)
        {
            this.name = name;
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitBus(this);
        }

        public override string Name()
        {
            return name;
        }
        public override int NetPrice()
        {
            return 5;
        }
        public override int DiscountPrice()
        {
            return 5;
        }
    }
}