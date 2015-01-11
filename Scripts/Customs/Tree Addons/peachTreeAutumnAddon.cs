using System;
using Server;

namespace Server.Items
{
	public class PeachTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PeachTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public PeachTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3487 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3484 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PeachTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class PeachTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PeachTreeAutumnAddon();
			}
		}

		[Constructable]
		public PeachTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn peach tree";
		}

		public PeachTreeAutumnAddonDeed( Serial serial ) : base( serial )
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