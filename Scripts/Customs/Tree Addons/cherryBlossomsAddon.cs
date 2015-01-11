using System;
using Server;

namespace Server.Items
{
	public class CherryTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CherryTreeAddonDeed();
			}
		}

		[Constructable]
		public CherryTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9329 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9334 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CherryTreeAddon( Serial serial ) : base( serial )
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

	public class CherryTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CherryTreeAddon();
			}
		}

		[Constructable]
		public CherryTreeAddonDeed()
		{
			Name = "a deed to a blossoming cherry tree";
		}

		public CherryTreeAddonDeed( Serial serial ) : base( serial )
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