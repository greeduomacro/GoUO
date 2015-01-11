using System;
using Server;

namespace Server.Items
{
	public class JungleTree1WithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree1WithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTree1WithVineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3405 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 3406 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3407 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3408 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3409 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3410 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3411 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 3393 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3394 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3395 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3396 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3434 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3435 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3436 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3437 );
			AddComponent( ac, -2, 2, 0 );

		}

		public JungleTree1WithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTree1WithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree1WithVineAddon();
			}
		}

		[Constructable]
		public JungleTree1WithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree1WithVineAddonDeed( Serial serial ) : base( serial )
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