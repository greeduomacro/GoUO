using System;
using Server;

namespace Server.Items
{
	public class CherryTree3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CherryTree3AddonDeed();
			}
		}

		[Constructable]
		public CherryTree3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9333 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9335 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CherryTree3Addon( Serial serial ) : base( serial )
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

	public class CherryTree3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CherryTree3Addon();
			}
		}

		[Constructable]
		public CherryTree3AddonDeed()
		{
			Name = "a deed to a blossoming cherry tree";
		}

		public CherryTree3AddonDeed( Serial serial ) : base( serial )
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