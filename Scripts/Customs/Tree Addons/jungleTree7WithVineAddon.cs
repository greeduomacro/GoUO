using System;
using Server;

namespace Server.Items
{
	public class JungleTree7WithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree7WithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTree7WithVineAddon()
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
			ac = new AddonComponent( 3458 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3457 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3456 );
			AddComponent( ac, -1, 1, 0 );

		}

		public JungleTree7WithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTree7WithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree7WithVineAddon();
			}
		}

		[Constructable]
		public JungleTree7WithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree7WithVineAddonDeed( Serial serial ) : base( serial )
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