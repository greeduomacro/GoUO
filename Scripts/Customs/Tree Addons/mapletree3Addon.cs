using System;
using Server;

namespace Server.Items
{
	public class MapleTree3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MapleTree3AddonDeed();
			}
		}

		[Constructable]
		public MapleTree3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9342 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9340 );
			AddComponent( ac, 0, 0, 0 );

		}

		public MapleTree3Addon( Serial serial ) : base( serial )
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

	public class MapleTree3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MapleTree3Addon();
			}
		}

		[Constructable]
		public MapleTree3AddonDeed()
		{
			Name = "a deed to a maple tree";
		}

		public MapleTree3AddonDeed( Serial serial ) : base( serial )
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