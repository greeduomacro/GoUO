using System;
using Server;

namespace Server.Items
{
	public class TreeNoFoliageAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeNoFoliageAddonDeed();
			}
		}

		[Constructable]
		public TreeNoFoliageAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3274 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeNoFoliageAddon( Serial serial ) : base( serial )
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

	public class TreeNoFoliageAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeNoFoliageAddon();
			}
		}

		[Constructable]
		public TreeNoFoliageAddonDeed()
		{
			Name = "a deed to a tree with no foilage";
		}

		public TreeNoFoliageAddonDeed( Serial serial ) : base( serial )
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