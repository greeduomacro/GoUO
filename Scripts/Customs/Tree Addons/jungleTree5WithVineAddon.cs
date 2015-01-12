using System;
using Server;

namespace Server.Items
{
	public class JungleTree5WithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree5WithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTree5WithVineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3450 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 3451 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3438 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3452 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3453 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3454 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3455 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3439 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3440 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3441 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3442 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3434 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3435 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3436 );
			AddComponent( ac, 1, 0, 0 );

		}

		public JungleTree5WithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTree5WithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree5WithVineAddon();
			}
		}

		[Constructable]
		public JungleTree5WithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree5WithVineAddonDeed( Serial serial ) : base( serial )
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