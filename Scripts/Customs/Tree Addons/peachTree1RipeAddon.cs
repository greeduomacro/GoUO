using System;
using Server;

namespace Server.Items
{
	public class PeachTree1RipeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PeachTree1RipeAddonDeed();
			}
		}

		[Constructable]
		public PeachTree1RipeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3490 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3488 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PeachTree1RipeAddon( Serial serial ) : base( serial )
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

	public class PeachTree1RipeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PeachTree1RipeAddon();
			}
		}

		[Constructable]
		public PeachTree1RipeAddonDeed()
		{
			Name = "a deed to a ripe peach tree";
		}

		public PeachTree1RipeAddonDeed( Serial serial ) : base( serial )
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