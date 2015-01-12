using System;
using Server;

namespace Server.Items
{
	public class WillowTreeSilverAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WillowTreeSilverAddonDeed();
			}
		}

		[Constructable]
		public WillowTreeSilverAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8778 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WillowTreeSilverAddon( Serial serial ) : base( serial )
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

	public class WillowTreeSilverAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WillowTreeSilverAddon();
			}
		}

		[Constructable]
		public WillowTreeSilverAddonDeed()
		{
			Name = "a deed to a silver willow tree";
		}

		public WillowTreeSilverAddonDeed( Serial serial ) : base( serial )
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