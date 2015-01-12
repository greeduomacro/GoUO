using System;
using Server;

namespace Server.Items
{
	public class BananaTreeGrownAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BananaTreeGrownAddonDeed();
			}
		}

		[Constructable]
		public BananaTreeGrownAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3242 );
			AddComponent( ac, 0, 0, 0 );

		}

		public BananaTreeGrownAddon( Serial serial ) : base( serial )
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

	public class BananaTreeGrownAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BananaTreeGrownAddon();
			}
		}

		[Constructable]
		public BananaTreeGrownAddonDeed()
		{
			Name = "a deed to a fully grown banana tree";
		}

		public BananaTreeGrownAddonDeed( Serial serial ) : base( serial )
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