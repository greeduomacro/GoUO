using System;
using Server;

namespace Server.Items
{
	public class AppleTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AppleTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public AppleTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3480 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3483 );
			AddComponent( ac, 0, 0, 0 );

		}

		public AppleTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class AppleTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AppleTreeAutumnAddon();
			}
		}

		[Constructable]
		public AppleTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn apple tree";
		}

		public AppleTreeAutumnAddonDeed( Serial serial ) : base( serial )
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