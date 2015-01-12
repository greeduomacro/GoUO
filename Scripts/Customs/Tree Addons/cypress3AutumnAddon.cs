using System;
using Server;

namespace Server.Items
{
	public class Cypress3AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cypress3AutumnAddonDeed();
			}
		}

		[Constructable]
		public Cypress3AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3329 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3331 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Cypress3AutumnAddon( Serial serial ) : base( serial )
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

	public class Cypress3AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cypress3AutumnAddon();
			}
		}

		[Constructable]
		public Cypress3AutumnAddonDeed()
		{
			Name = "a deed to an autumn cypress tree";
		}

		public Cypress3AutumnAddonDeed( Serial serial ) : base( serial )
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