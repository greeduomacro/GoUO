using System;
using Server;

namespace Server.Items
{
	public class WillowTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WillowTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public WillowTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3302 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3304 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WillowTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class WillowTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WillowTreeAutumnAddon();
			}
		}

		[Constructable]
		public WillowTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn willow tree";
		}

		public WillowTreeAutumnAddonDeed( Serial serial ) : base( serial )
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