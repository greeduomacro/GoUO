using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class SmSqPillow : Item
    {
        [Constructable]
        public SmSqPillow() : base(0x163C)
        {
            Name = "Small Square Pillow";
            Stackable = false;
            Weight = 1.0;
        }

        public SmSqPillow(Serial serial)
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