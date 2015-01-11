using System;
using Server;

namespace Server.Items
{
	public class Cypress2AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cypress2AutumnAddonDeed();
			}
		}

		[Constructable]
		public Cypress2AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3326 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3328 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Cypress2AutumnAddon( Serial serial ) : base( serial )
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

	public class Cypress2AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cypress2AutumnAddon();
			}
		}

		[Constructable]
		public Cypress2AutumnAddonDeed()
		{
			Name = "a deed to an autumn cypress tree";
		}

		public Cypress2AutumnAddonDeed( Serial serial ) : base( serial )
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