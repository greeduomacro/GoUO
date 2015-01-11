using System;
using Server;

namespace Server.Items
{
	public class Cypress3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cypress3AddonDeed();
			}
		}

		[Constructable]
		public Cypress3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3329 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3330 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Cypress3Addon( Serial serial ) : base( serial )
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

	public class Cypress3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cypress3Addon();
			}
		}

		[Constructable]
		public Cypress3AddonDeed()
		{
			Name = "a deed to a cypress tree";
		}

		public Cypress3AddonDeed( Serial serial ) : base( serial )
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