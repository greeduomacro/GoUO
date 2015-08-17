using System; 
using Server.Mobiles;

namespace Server.Items
{
   public class EtherealChargerOfTheFallen : EtherealMount
    {

        [Constructable]
        public EtherealChargerOfTheFallen()
            : base(11670, 0x3E91)
        {
            Name = "Ethereal Charger Of The Fallen Statuette";
            ItemID = 11676;
            MountedID = 16018;
            RegularID = 11676;
            LootType = LootType.Blessed;
        }

        public EtherealChargerOfTheFallen(Serial serial)
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

            if (Name != "Ethereal Charger Of The Fallen Statuette")
                Name = "Ethereal Charger Of The Fallen Statuette";
        }
    }
}