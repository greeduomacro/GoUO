using System;
using Server;

namespace Server.Items
{
	public class SmallPalm3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallPalm3AddonDeed();
			}
		}

		[Constructable]
		public SmallPalm3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3227 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SmallPalm3Addon( Serial serial ) : base( serial )
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

	public class SmallPalm3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallPalm3Addon();
			}
		}

		[Constructable]
		public SmallPalm3AddonDeed()
		{
			Name = "a deed to a small palm tree";
		}

		public SmallPalm3AddonDeed( Serial serial ) : base( serial )
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