using System;
using Server;

namespace Server.Items
{
	public class CedarTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CedarTreeAddonDeed();
			}
		}

		[Constructable]
		public CedarTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3286 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CedarTreeAddon( Serial serial ) : base( serial )
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

	public class CedarTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CedarTreeAddon();
			}
		}

		[Constructable]
		public CedarTreeAddonDeed()
		{
			Name = "a deed to a cedar tree";
		}

		public CedarTreeAddonDeed( Serial serial ) : base( serial )
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