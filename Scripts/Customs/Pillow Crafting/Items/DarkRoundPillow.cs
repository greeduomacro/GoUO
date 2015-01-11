using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class DarkRoundPillow : Item
    {
        [Constructable]
        public DarkRoundPillow() : base(0x13A7)
        {
            Name = "Dark Round Pillow";
            Stackable = false;
            Weight = 1.0;
        }

        public DarkRoundPillow(Serial serial)
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