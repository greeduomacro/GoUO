using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class LgSqPillow : Item
    {
        [Constructable]
        public LgSqPillow() : base(0x163A)
        {
            Name = "Large Square Pillow";
            Stackable = false;
            Weight = 1.0;
        }

        public LgSqPillow(Serial serial)
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