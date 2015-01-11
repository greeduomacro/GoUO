using System;
using Server;

namespace Server.Items
{
	public class TreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeAddonDeed();
			}
		}

		[Constructable]
		public TreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3278 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3276 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeAddon( Serial serial ) : base( serial )
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

	public class TreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeAddon();
			}
		}

		[Constructable]
		public TreeAddonDeed()
		{
			Name = "a deed to a tree";
		}

		public TreeAddonDeed( Serial serial ) : base( serial )
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