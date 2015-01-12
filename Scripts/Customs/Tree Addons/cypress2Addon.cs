using System;
using Server;

namespace Server.Items
{
	public class Cypress2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cypress2AddonDeed();
			}
		}

		[Constructable]
		public Cypress2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3326 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3327 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Cypress2Addon( Serial serial ) : base( serial )
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

	public class Cypress2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cypress2Addon();
			}
		}

		[Constructable]
		public Cypress2AddonDeed()
		{
			Name = "a deed to a cypress tree";
		}

		public Cypress2AddonDeed( Serial serial ) : base( serial )
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