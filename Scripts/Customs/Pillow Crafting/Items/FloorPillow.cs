using System;
using Server;

namespace Server.Items
{


    [Flipable(0x13AD, 0x13AE)]
    public class FloorPillow : Item, IDyable
    {
        [Constructable]
        public FloorPillow() : base(0x13AD)
        {
            Name = "a floor pillow";
        }


        public FloorPillow(Serial serial)
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

