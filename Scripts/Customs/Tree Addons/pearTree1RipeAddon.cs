using System;
using Server;

namespace Server.Items
{
	public class PearTree1RipeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PearTree1RipeAddonDeed();
			}
		}

		[Constructable]
		public PearTree1RipeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3498 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3496 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PearTree1RipeAddon( Serial serial ) : base( serial )
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

	public class PearTree1RipeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PearTree1RipeAddon();
			}
		}

		[Constructable]
		public PearTree1RipeAddonDeed()
		{
			Name = "a deed to a ripe pear tree";
		}

		public PearTree1RipeAddonDeed( Serial serial ) : base( serial )
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