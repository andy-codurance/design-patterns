namespace Visitor
{
    using System.Collections.Generic;

    public class Chassis : Equipment
    {
        private string name = "Chasis";
        private readonly List<Equipment> parts = new List<Equipment>();

        public override void Accept(EquipmentVisitor visitor)
        {
            foreach (var part in parts)
            {
                part.Accept(visitor);
            }
            visitor.VisitChassis(this);
        }

        public override string Name()
        {
            return name;
        }
        public override int NetPrice()
        {
            return 50;
        }
        public override int DiscountPrice()
        {
            return 40;
        }

        public void Add(Equipment equipment)
        {
            parts.Add(equipment);
        }
    }
}