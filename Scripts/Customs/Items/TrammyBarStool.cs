using System;
using Server;
using Server.Items;

namespace Server.Items
{

    public class TrammyBarStool : BaseHat
    {
	
		private static int[] m_Hues = new int[]
		{
			0x0, 0x455, 0x47E, 0x89F, 0x8A5, 0x8AB, 
			0x966, 0x96D, 0x972, 0x973, 0x979
		};
		
        [Constructable]
        public TrammyBarStool() : base( 0x1547 )
        {
            Weight = 5.0;
            Name = "Trammy Barstool";
			Hue = Utility.RandomList( m_Hues );
            LootType = LootType.Blessed;
        }

        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public TrammyBarStool(Serial serial)
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