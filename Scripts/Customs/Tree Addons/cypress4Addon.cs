using System;
using Server;

namespace Server.Items
{
	public class Cypress4Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cypress4AddonDeed();
			}
		}

		[Constructable]
		public Cypress4Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3320 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3321 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Cypress4Addon( Serial serial ) : base( serial )
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

	public class Cypress4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cypress4Addon();
			}
		}

		[Constructable]
		public Cypress4AddonDeed()
		{
			Name = "a deed to a cypress tree";
		}

		public Cypress4AddonDeed( Serial serial ) : base( serial )
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