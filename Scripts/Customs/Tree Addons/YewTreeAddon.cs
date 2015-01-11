using System;
using Server;

namespace Server.Items
{
	public class YewTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new YewTreeAddonDeed();
			}
		}

		[Constructable]
		public YewTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4800 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 4801 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 4802 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4803 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4804 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 4805 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 4806 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 4807 );
			AddComponent( ac, 5, -4, 0 );
			ac = new AddonComponent( 4791 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 4792 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 4793 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4794 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4795 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 4796 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 4797 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 4798 );
			AddComponent( ac, -4, 5, 0 );
			ac = new AddonComponent( 4799 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 4790 );
			AddComponent( ac, -3, 4, 0 );

		}

		public YewTreeAddon( Serial serial ) : base( serial )
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

	public class YewTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new YewTreeAddon();
			}
		}

		[Constructable]
		public YewTreeAddonDeed()
		{
			Name = "a deed to a yew tree";
		}

		public YewTreeAddonDeed( Serial serial ) : base( serial )
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