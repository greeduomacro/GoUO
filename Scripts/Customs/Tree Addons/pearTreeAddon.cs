using System;
using Server;

namespace Server.Items
{
	public class PearTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PearTreeAddonDeed();
			}
		}

		[Constructable]
		public PearTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3492 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3493 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PearTreeAddon( Serial serial ) : base( serial )
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

	public class PearTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PearTreeAddon();
			}
		}

		[Constructable]
		public PearTreeAddonDeed()
		{
			Name = "a deed to a pear tree";
		}

		public PearTreeAddonDeed( Serial serial ) : base( serial )
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