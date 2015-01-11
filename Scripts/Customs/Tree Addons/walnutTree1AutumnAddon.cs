using System;
using Server;

namespace Server.Items
{
	public class WalnutTree1AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WalnutTree1AutumnAddonDeed();
			}
		}

		[Constructable]
		public WalnutTree1AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3299 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3301 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WalnutTree1AutumnAddon( Serial serial ) : base( serial )
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

	public class WalnutTree1AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WalnutTree1AutumnAddon();
			}
		}

		[Constructable]
		public WalnutTree1AutumnAddonDeed()
		{
			Name = "a deed to an autumn walnut tree";
		}

		public WalnutTree1AutumnAddonDeed( Serial serial ) : base( serial )
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