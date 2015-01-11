using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class MedSqPillow : Item
    {
        [Constructable]
        public MedSqPillow() : base(0x163B)
        {
            Name = "Medium Square Pillow";
            Stackable = false;
            Weight = 1.0;
        }

        public MedSqPillow(Serial serial)
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