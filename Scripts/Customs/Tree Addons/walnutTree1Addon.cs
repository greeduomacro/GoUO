using System;
using Server;

namespace Server.Items
{
	public class WalnutTree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WalnutTree1AddonDeed();
			}
		}

		[Constructable]
		public WalnutTree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3299 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3300 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WalnutTree1Addon( Serial serial ) : base( serial )
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

	public class WalnutTree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WalnutTree1Addon();
			}
		}

		[Constructable]
		public WalnutTree1AddonDeed()
		{
			Name = "a deed to a walnut tree";
		}

		public WalnutTree1AddonDeed( Serial serial ) : base( serial )
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