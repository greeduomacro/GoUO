using System;
using Server;

namespace Server.Items
{
	public class JungleTree4Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree4AddonDeed();
			}
		}

		[Constructable]
		public JungleTree4Addon()
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

		}

		public JungleTree4Addon( Serial serial ) : base( serial )
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

	public class JungleTree4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree4Addon();
			}
		}

		[Constructable]
		public JungleTree4AddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree4AddonDeed( Serial serial ) : base( serial )
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