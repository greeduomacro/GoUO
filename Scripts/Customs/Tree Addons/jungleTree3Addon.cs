using System;
using Server;

namespace Server.Items
{
	public class JungleTree3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree3AddonDeed();
			}
		}

		[Constructable]
		public JungleTree3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3430 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3417 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3427 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 3428 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3429 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3415 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3416 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3431 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3432 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3433 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 3418 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3419 );
			AddComponent( ac, 2, -2, 0 );

		}

		public JungleTree3Addon( Serial serial ) : base( serial )
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

	public class JungleTree3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree3Addon();
			}
		}

		[Constructable]
		public JungleTree3AddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree3AddonDeed( Serial serial ) : base( serial )
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