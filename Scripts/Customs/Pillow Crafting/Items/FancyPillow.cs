using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class FancyPillow : Item
    {
        [Constructable]
        public FancyPillow() : base(0x1915)
        {
            Name = "Fancy Pillow";
            Stackable = false;
            Weight = 1.0;
        }

        public FancyPillow(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}