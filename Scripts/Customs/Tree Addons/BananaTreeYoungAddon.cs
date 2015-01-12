using System;
using Server;

namespace Server.Items
{
	public class BananaTreeYoungAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BananaTreeYoungAddonDeed();
			}
		}

		[Constructable]
		public BananaTreeYoungAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3240 );
			AddComponent( ac, 0, 0, 0 );

		}

		public BananaTreeYoungAddon( Serial serial ) : base( serial )
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

	public class BananaTreeYoungAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BananaTreeYoungAddon();
			}
		}

		[Constructable]
		public BananaTreeYoungAddonDeed()
		{
			Name = "a deed to a young banana tree";
		}

		public BananaTreeYoungAddonDeed( Serial serial ) : base( serial )
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