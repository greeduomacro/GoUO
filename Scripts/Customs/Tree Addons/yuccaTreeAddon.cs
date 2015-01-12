using System;
using Server;

namespace Server.Items
{
	public class YuccaTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new YuccaTreeAddonDeed();
			}
		}

		[Constructable]
		public YuccaTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3383 );
			AddComponent( ac, 0, 0, 0 );

		}

		public YuccaTreeAddon( Serial serial ) : base( serial )
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

	public class YuccaTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new YuccaTreeAddon();
			}
		}

		[Constructable]
		public YuccaTreeAddonDeed()
		{
			Name = "a deed to a yucca tree";
		}

		public YuccaTreeAddonDeed( Serial serial ) : base( serial )
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