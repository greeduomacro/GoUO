using System;
using Server;

namespace Server.Items
{
	public class JungleTree2WithVineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JungleTree2WithVineAddonDeed();
			}
		}

		[Constructable]
		public JungleTree2WithVineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3421 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 3422 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3423 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3424 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3425 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3426 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3415 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 3416 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3417 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3418 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3419 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3413 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3414 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3412 );
			AddComponent( ac, -1, 2, 0 );

		}

		public JungleTree2WithVineAddon( Serial serial ) : base( serial )
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

	public class JungleTree2WithVineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JungleTree2WithVineAddon();
			}
		}

		[Constructable]
		public JungleTree2WithVineAddonDeed()
		{
			Name = "a deed to a jungle tree";
		}

		public JungleTree2WithVineAddonDeed( Serial serial ) : base( serial )
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