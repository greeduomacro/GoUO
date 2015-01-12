using System;
using Server;

namespace Server.Items
{
	public class SpiderTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SpiderTreeAddonDeed();
			}
		}

		[Constructable]
		public SpiderTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3273 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SpiderTreeAddon( Serial serial ) : base( serial )
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

	public class SpiderTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SpiderTreeAddon();
			}
		}

		[Constructable]
		public SpiderTreeAddonDeed()
		{
			Name = "a deed to a spider tree";
		}

		public SpiderTreeAddonDeed( Serial serial ) : base( serial )
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