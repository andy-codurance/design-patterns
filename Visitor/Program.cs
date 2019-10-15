using System;

namespace Visitor
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Equipment
    {
        public abstract void Accept(EquipmentVisitor visitor);

        public abstract string Name();
        public abstract int NetPrice();
        public abstract int DiscountPrice();
    }

    public class FloppyDisk : Equipment
    {
        private string name;

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

    public class Card : Equipment
    {
        private string name;

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

    public class Chassis : Equipment
    {
        private string name;
        private List<Equipment> parts;

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
    }                                                               

    public class Bus : Equipment
    {
        private string name;

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

    public abstract class EquipmentVisitor
    {
        public abstract void VisitFloppyDisk(FloppyDisk floppyDisk);
        public abstract void VisitCard(Card card);
        public abstract void VisitChassis(Chassis chassis);
        public abstract void VisitBus(Bus bus);
    }

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