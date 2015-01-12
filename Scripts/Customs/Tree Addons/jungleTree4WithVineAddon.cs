using System;
using Server;

namespace Server.Items
{
	public class JungleTree4WithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree4WithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTree4WithVineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3448 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3449 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 3442 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3443 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 3444 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3445 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3446 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3447 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3438 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3439 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3440 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3441 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3473 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3474 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3475 );
			AddComponent( ac, 1, -1, 0 );

		}

		public JungleTree4WithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTree4WithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree4WithVineAddon();
			}
		}

		[Constructable]
		public JungleTree4WithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree4WithVineAddonDeed( Serial serial ) : base( serial )
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