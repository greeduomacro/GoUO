using System;
using Server;

namespace Server.Items
{
	public class AppleTreeRipeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AppleTreeRipeAddonDeed();
			}
		}

		[Constructable]
		public AppleTreeRipeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3478 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3476 );
			AddComponent( ac, 0, 0, 0 );
		}

		public AppleTreeRipeAddon( Serial serial ) : base( serial )
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

	public class AppleTreeRipeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AppleTreeRipeAddon();
			}
		}

		[Constructable]
		public AppleTreeRipeAddonDeed()
		{
			Name = "a deed to a ripe apple tree";
		}

		public AppleTreeRipeAddonDeed( Serial serial ) : base( serial )
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