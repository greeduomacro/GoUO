using System;
using Server;

namespace Server.Items
{
	public class TreeSaplingAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeSaplingAddonDeed();
			}
		}

		[Constructable]
		public TreeSaplingAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3305 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeSaplingAddon( Serial serial ) : base( serial )
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

	public class TreeSaplingAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeSaplingAddon();
			}
		}

		[Constructable]
		public TreeSaplingAddonDeed()
		{
			Name = "a deed to a tree sapling";
		}

		public TreeSaplingAddonDeed( Serial serial ) : base( serial )
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