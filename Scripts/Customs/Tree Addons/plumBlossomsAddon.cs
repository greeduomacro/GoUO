using System;
using Server;

namespace Server.Items
{
	public class PlumTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PlumTreeAddonDeed();
			}
		}

		[Constructable]
		public PlumTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9965 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9967 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PlumTreeAddon( Serial serial ) : base( serial )
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

	public class PlumTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PlumTreeAddon();
			}
		}

		[Constructable]
		public PlumTreeAddonDeed()
		{
			Name = "a deed to a blossoming plum tree";
		}

		public PlumTreeAddonDeed( Serial serial ) : base( serial )
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