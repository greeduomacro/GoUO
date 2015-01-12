using System;
using Server;

namespace Server.Items
{
	public class WillowTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WillowTreeAddonDeed();
			}
		}

		[Constructable]
		public WillowTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3302 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3303 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WillowTreeAddon( Serial serial ) : base( serial )
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

	public class WillowTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WillowTreeAddon();
			}
		}

		[Constructable]
		public WillowTreeAddonDeed()
		{
			Name = "a deed to a willow tree";
		}

		public WillowTreeAddonDeed( Serial serial ) : base( serial )
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