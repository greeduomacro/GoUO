using System;
using Server;

namespace Server.Items
{
	public class WillowTreeGoldAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WillowTreeGoldAddonDeed();
			}
		}

		[Constructable]
		public WillowTreeGoldAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8779 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WillowTreeGoldAddon( Serial serial ) : base( serial )
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

	public class WillowTreeGoldAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WillowTreeGoldAddon();
			}
		}

		[Constructable]
		public WillowTreeGoldAddonDeed()
		{
			Name = "a deed to a golden willow tree";
		}

		public WillowTreeGoldAddonDeed( Serial serial ) : base( serial )
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