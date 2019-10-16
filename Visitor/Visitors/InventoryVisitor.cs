namespace Visitor
{
    using System;

    public class InventoryVisitor : EquipmentVisitor
    {
        private string inventory;
        
        public override void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            throw new NotImplementedException();
        }

        public override void VisitCard(Card card)
        {
            throw new NotImplementedException();
        }

        public override void VisitChassis(Chassis chassis)
        {
            throw new NotImplementedException();
        }

        public override void VisitBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public string GetInventory()
        {
            return inventory;
        }
    }
}