using System;
using Server;

namespace Server.Items
{
	public class PeachTreeRipeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PeachTreeRipeAddonDeed();
			}
		}

		[Constructable]
		public PeachTreeRipeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3486 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3484 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PeachTreeRipeAddon( Serial serial ) : base( serial )
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

	public class PeachTreeRipeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PeachTreeRipeAddon();
			}
		}

		[Constructable]
		public PeachTreeRipeAddonDeed()
		{
			Name = "a deed to a ripe peach tree";
		}

		public PeachTreeRipeAddonDeed( Serial serial ) : base( serial )
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