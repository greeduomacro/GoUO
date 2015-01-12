using System;
using Server;

namespace Server.Items
{
	public class MapleTree2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MapleTree2AddonDeed();
			}
		}

		[Constructable]
		public MapleTree2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9341 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9338 );
			AddComponent( ac, 0, 0, 0 );

		}

		public MapleTree2Addon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( (int)0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}

	public class MapleTree2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MapleTree2Addon();
			}
		}

		[Constructable]
		public MapleTree2AddonDeed()
		{
			Name = "a deed to a maple tree";
		}

		public MapleTree2AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( (int)0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}
}