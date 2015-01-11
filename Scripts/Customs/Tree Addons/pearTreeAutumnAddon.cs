using System;
using Server;

namespace Server.Items
{
	public class PearTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PearTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public PearTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3492 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3495 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PearTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class PearTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PearTreeAutumnAddon();
			}
		}

		[Constructable]
		public PearTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn pear tree";
		}

		public PearTreeAutumnAddonDeed( Serial serial ) : base( serial )
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