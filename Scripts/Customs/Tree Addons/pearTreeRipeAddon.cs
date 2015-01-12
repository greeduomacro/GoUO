using System;
using Server;

namespace Server.Items
{
	public class PearTreeRipeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PearTreeRipeAddonDeed();
			}
		}

		[Constructable]
		public PearTreeRipeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3494 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3492 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PearTreeRipeAddon( Serial serial ) : base( serial )
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

	public class PearTreeRipeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PearTreeRipeAddon();
			}
		}

		[Constructable]
		public PearTreeRipeAddonDeed()
		{
			Name = "a deed to a ripe pear tree";
		}

		public PearTreeRipeAddonDeed( Serial serial ) : base( serial )
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