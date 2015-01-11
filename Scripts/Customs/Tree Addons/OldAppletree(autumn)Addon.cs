using System;
using Server;

namespace Server.Items
{
	public class OldAppleTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OldAppleTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public OldAppleTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3480 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3483 );
			AddComponent( ac, 0, 0, 0 );
		}

		public OldAppleTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class OldAppleTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OldAppleTreeAutumnAddon();
			}
		}

		[Constructable]
		public OldAppleTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn old apple tree";
		}

		public OldAppleTreeAutumnAddonDeed( Serial serial ) : base( serial )
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