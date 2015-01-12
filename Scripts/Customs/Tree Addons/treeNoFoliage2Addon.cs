using System;
using Server;

namespace Server.Items
{
	public class TreeNoFoliage2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeNoFoliage2AddonDeed();
			}
		}

		[Constructable]
		public TreeNoFoliage2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3277 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeNoFoliage2Addon( Serial serial ) : base( serial )
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

	public class TreeNoFoliage2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeNoFoliage2Addon();
			}
		}

		[Constructable]
		public TreeNoFoliage2AddonDeed()
		{
			Name = "a deed to a tree with no foilage";
		}

		public TreeNoFoliage2AddonDeed( Serial serial ) : base( serial )
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