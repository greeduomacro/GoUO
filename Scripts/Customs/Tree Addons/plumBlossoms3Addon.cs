using System;
using Server;

namespace Server.Items
{
	public class PlumTree3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PlumTree3AddonDeed();
			}
		}

		[Constructable]
		public PlumTree3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9969 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9966 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PlumTree3Addon( Serial serial ) : base( serial )
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

	public class PlumTree3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PlumTree3Addon();
			}
		}

		[Constructable]
		public PlumTree3AddonDeed()
		{
			Name = "a deed to a blossoming plum tree";
		}

		public PlumTree3AddonDeed( Serial serial ) : base( serial )
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