using System;
using Server;

namespace Server.Items
{
	public class JungleTree6WithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree6WithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTree6WithVineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3463 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3464 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3465 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3466 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3467 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3460 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3461 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3462 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3473 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3474 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3475 );
			AddComponent( ac, 1, -1, 0 );

		}

		public JungleTree6WithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTree6WithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree6WithVineAddon();
			}
		}

		[Constructable]
		public JungleTree6WithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree6WithVineAddonDeed( Serial serial ) : base( serial )
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