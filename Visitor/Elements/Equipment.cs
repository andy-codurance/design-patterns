namespace Visitor
{
    public abstract class Equipment
    {
        public abstract void Accept(EquipmentVisitor visitor);

        public abstract string Name();
        public abstract int NetPrice();
        public abstract int DiscountPrice();
    }
}