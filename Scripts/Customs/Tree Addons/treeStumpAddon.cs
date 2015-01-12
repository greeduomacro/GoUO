using System;
using Server;

namespace Server.Items
{
	public class TreeStumpAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeStumpAddonDeed();
			}
		}

		[Constructable]
		public TreeStumpAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3500 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeStumpAddon( Serial serial ) : base( serial )
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

	public class TreeStumpAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeStumpAddon();
			}
		}

		[Constructable]
		public TreeStumpAddonDeed()
		{
			Name = "a deed to a tree stump";
		}

		public TreeStumpAddonDeed( Serial serial ) : base( serial )
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