using System;
using Server;

namespace Server.Items
{
	public class WalnutTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WalnutTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public WalnutTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3298 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3296 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WalnutTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class WalnutTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WalnutTreeAutumnAddon();
			}
		}

		[Constructable]
		public WalnutTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn walnut tree";
		}

		public WalnutTreeAutumnAddonDeed( Serial serial ) : base( serial )
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