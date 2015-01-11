using System;
using Server;

namespace Server.Items
{
	public class SmallPalm4Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallPalm4AddonDeed();
			}
		}

		[Constructable]
		public SmallPalm4Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3228 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SmallPalm4Addon( Serial serial ) : base( serial )
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

	public class SmallPalm4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallPalm4Addon();
			}
		}

		[Constructable]
		public SmallPalm4AddonDeed()
		{
			Name = "a deed to a small palm tree";
		}

		public SmallPalm4AddonDeed( Serial serial ) : base( serial )
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