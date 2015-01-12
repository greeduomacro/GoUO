using System;
using Server;

namespace Server.Items
{
	public class PeachTree1AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PeachTree1AutumnAddonDeed();
			}
		}

		[Constructable]
		public PeachTree1AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3488 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3491 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PeachTree1AutumnAddon( Serial serial ) : base( serial )
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

	public class PeachTree1AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PeachTree1AutumnAddon();
			}
		}

		[Constructable]
		public PeachTree1AutumnAddonDeed()
		{
			Name = "a deed to an autumn peach tree";
		}

		public PeachTree1AutumnAddonDeed( Serial serial ) : base( serial )
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