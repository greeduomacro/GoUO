using System;
using Server;

namespace Server.Items
{
	public class SmallPalm1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallPalm1AddonDeed();
			}
		}

		[Constructable]
		public SmallPalm1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3226 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SmallPalm1Addon( Serial serial ) : base( serial )
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

	public class SmallPalm1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallPalm1Addon();
			}
		}

		[Constructable]
		public SmallPalm1AddonDeed()
		{
			Name = "a deed to a small palm tree";
		}

		public SmallPalm1AddonDeed( Serial serial ) : base( serial )
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