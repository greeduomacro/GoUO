using System;
using Server;

namespace Server.Items
{
	public class CedarTreeWinterAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CedarTreeWinterAddonDeed();
			}
		}

		[Constructable]
		public CedarTreeWinterAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3288 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CedarTreeWinterAddon( Serial serial ) : base( serial )
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

	public class CedarTreeWinterAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CedarTreeWinterAddon();
			}
		}

		[Constructable]
		public CedarTreeWinterAddonDeed()
		{
			Name = "a deed to a winter cedar tree";
		}

		public CedarTreeWinterAddonDeed( Serial serial ) : base( serial )
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