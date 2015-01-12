using System;
using Server;

namespace Server.Items
{
	public class OldAppleTreeRipeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OldAppleTreeRipeAddonDeed();
			}
		}

		[Constructable]
		public OldAppleTreeRipeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3482 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3480 );
			AddComponent( ac, 0, 0, 0 );
		}

		public OldAppleTreeRipeAddon( Serial serial ) : base( serial )
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

	public class OldAppleTreeRipeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OldAppleTreeRipeAddon();
			}
		}

		[Constructable]
		public OldAppleTreeRipeAddonDeed()
		{
			Name = "a deed to a ripe old apple tree";
		}

		public OldAppleTreeRipeAddonDeed( Serial serial ) : base( serial )
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