using System;
using Server;

namespace Server.Items
{
	public class PlumTree5Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PlumTree5AddonDeed();
			}
		}

		[Constructable]
		public PlumTree5Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9966 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9971 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PlumTree5Addon( Serial serial ) : base( serial )
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

	public class PlumTree5AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PlumTree5Addon();
			}
		}

		[Constructable]
		public PlumTree5AddonDeed()
		{
			Name = "a deed to a blossoming plum tree";
		}

		public PlumTree5AddonDeed( Serial serial ) : base( serial )
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