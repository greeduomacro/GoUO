using System;
using Server;

namespace Server.Items
{
	public class WalnutTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WalnutTreeAddonDeed();
			}
		}

		[Constructable]
		public WalnutTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3296 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3297 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WalnutTreeAddon( Serial serial ) : base( serial )
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

	public class WalnutTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WalnutTreeAddon();
			}
		}

		[Constructable]
		public WalnutTreeAddonDeed()
		{
			Name = "a deed to a walnut tree";
		}

		public WalnutTreeAddonDeed( Serial serial ) : base( serial )
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