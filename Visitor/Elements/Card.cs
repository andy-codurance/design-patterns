namespace Visitor
{
    public class Card : Equipment
    {
        private readonly string name;

        public Card(string name)
        {
            this.name = name;
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitCard(this);
        }

        public override string Name()
        {
            return name;
        }
        public override int NetPrice()
        {
            return 100;
        }
        public override int DiscountPrice()
        {
            return 50;
        }
    }
}