using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class DarkTassledPillow : Item
    {
        [Constructable]
        public DarkTassledPillow() : base(0x13AC)
        {
            Name = "Dark Tassled Pillow";
            Stackable = false;
            Weight = 1.0;
        }

        public DarkTassledPillow(Serial serial)
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