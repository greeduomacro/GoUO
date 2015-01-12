using System;
using Server;

namespace Server.Items
{
	public class Cypress1AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cypress1AutumnAddonDeed();
			}
		}

		[Constructable]
		public Cypress1AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3325 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3323 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Cypress1AutumnAddon( Serial serial ) : base( serial )
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

	public class Cypress1AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cypress1AutumnAddon();
			}
		}

		[Constructable]
		public Cypress1AutumnAddonDeed()
		{
			Name = "a deed to an autumn cypress tree";
		}

		public Cypress1AutumnAddonDeed( Serial serial ) : base( serial )
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