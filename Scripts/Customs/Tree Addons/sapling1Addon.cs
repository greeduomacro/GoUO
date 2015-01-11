using System;
using Server;

namespace Server.Items
{
	public class TreeSapling1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeSapling1AddonDeed();
			}
		}

		[Constructable]
		public TreeSapling1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3306 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeSapling1Addon( Serial serial ) : base( serial )
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

	public class TreeSapling1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeSapling1Addon();
			}
		}

		[Constructable]
		public TreeSapling1AddonDeed()
		{
			Name = "a deed to a tree sapling";
		}

		public TreeSapling1AddonDeed( Serial serial ) : base( serial )
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