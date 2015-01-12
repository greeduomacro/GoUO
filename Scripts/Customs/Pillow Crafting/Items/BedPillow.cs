using System;
using Server;

namespace Server.Items
{


    [Flipable(0x13A4, 0x13A5)]
    public class BedPillow : Item, IDyable
    {
        [Constructable]
        public BedPillow() : base(0x13A4)
        {
            Name = "a bed pillow";
        }


        public BedPillow(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public bool Dye(Mobile from, DyeTub sender)
        {
            if (Deleted)
                return false;

            Hue = sender.DyedHue;

            return true;
        }
    }
}

