using System; 
using Server.Mobiles;

namespace Server.Items
{
    public class EtherealChimera : EtherealMount
    {

        [Constructable]
        public EtherealChimera() : base(11670, 0x3E91)
        {
            Name = "Ethereal Chimera Statuette";
            ItemID = 11669;
            MountedID = 16016;
            RegularID = 11669;
            LootType = LootType.Blessed;
        }

        public EtherealChimera(Serial serial) : base(serial)
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

            if (Name != "Ethereal Chimera Statuette")
                Name = "Ethereal Chimera Statuette";
        }
    }
}