using System;
using Server;

namespace Server.Items
{
	public class TreeNoFoliage1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeNoFoliage1AddonDeed();
			}
		}

		[Constructable]
		public TreeNoFoliage1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3275 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeNoFoliage1Addon( Serial serial ) : base( serial )
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

	public class TreeNoFoliage1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeNoFoliage1Addon();
			}
		}

		[Constructable]
		public TreeNoFoliage1AddonDeed()
		{
			Name = "a deed to a tree with no foilage";
		}

		public TreeNoFoliage1AddonDeed( Serial serial ) : base( serial )
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