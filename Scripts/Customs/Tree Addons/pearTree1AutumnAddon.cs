using System;
using Server;

namespace Server.Items
{
	public class PearTree1AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PearTree1AutumnAddonDeed();
			}
		}

		[Constructable]
		public PearTree1AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3496 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3499 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PearTree1AutumnAddon( Serial serial ) : base( serial )
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

	public class PearTree1AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PearTree1AutumnAddon();
			}
		}

		[Constructable]
		public PearTree1AutumnAddonDeed()
		{
			Name = "a deed to an autumn pear tree";
		}

		public PearTree1AutumnAddonDeed( Serial serial ) : base( serial )
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