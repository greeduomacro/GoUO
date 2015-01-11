using System;
using Server;

namespace Server.Items
{
	public class OldAppleTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OldAppleTreeAddonDeed();
			}
		}

		[Constructable]
		public OldAppleTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3480 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3481 );
			AddComponent( ac, 0, 0, 0 );
		}

		public OldAppleTreeAddon( Serial serial ) : base( serial )
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

	public class OldAppleTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OldAppleTreeAddon();
			}
		}

		[Constructable]
		public OldAppleTreeAddonDeed()
		{
			Name = "a deed to an old apple tree";
		}

		public OldAppleTreeAddonDeed( Serial serial ) : base( serial )
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