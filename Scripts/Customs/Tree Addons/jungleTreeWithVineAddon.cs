using System;
using Server;

namespace Server.Items
{
	public class JungleTreeWithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTreeWithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTreeWithVineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3397 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 3398 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 3399 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3400 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3401 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3402 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3403 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3404 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 3393 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3394 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3395 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3396 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3412 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3413 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3414 );
			AddComponent( ac, 1, 0, 0 );

		}

		public JungleTreeWithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTreeWithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTreeWithVineAddon();
			}
		}

		[Constructable]
		public JungleTreeWithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTreeWithVineAddonDeed( Serial serial ) : base( serial )
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