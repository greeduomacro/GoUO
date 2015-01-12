using System;
using Server;

namespace Server.Items
{
	public class OhiiTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OhiiTreeAddonDeed();
			}
		}

		[Constructable]
		public OhiiTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3230 );
			AddComponent( ac, 0, 0, 0 );

		}

		public OhiiTreeAddon( Serial serial ) : base( serial )
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

	public class OhiiTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OhiiTreeAddon();
			}
		}

		[Constructable]
		public OhiiTreeAddonDeed()
		{
			Name = "a deed to a ohii tree";
		}

		public OhiiTreeAddonDeed( Serial serial ) : base( serial )
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