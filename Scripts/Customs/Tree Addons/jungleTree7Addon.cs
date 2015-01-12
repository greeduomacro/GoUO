using System;
using Server;

namespace Server.Items
{
	public class JungleTree7Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree7AddonDeed();
			}
		}

		[Constructable]
		public JungleTree7Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3468 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3469 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3470 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3471 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3472 );
			AddComponent( ac, 2, -2, 1 );
			ac = new AddonComponent( 3460 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3461 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3462 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3456 );
			AddComponent( ac, -1, 1, 0 );

		}

		public JungleTree7Addon( Serial serial ) : base( serial )
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

	public class JungleTree7AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree7Addon();
			}
		}

		[Constructable]
		public JungleTree7AddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree7AddonDeed( Serial serial ) : base( serial )
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