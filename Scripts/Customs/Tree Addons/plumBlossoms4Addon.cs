using System;
using Server;

namespace Server.Items
{
	public class PlumTree4Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PlumTree4AddonDeed();
			}
		}

		[Constructable]
		public PlumTree4Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9965 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9970 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PlumTree4Addon( Serial serial ) : base( serial )
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

	public class PlumTree4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PlumTree4Addon();
			}
		}

		[Constructable]
		public PlumTree4AddonDeed()
		{
			Name = "a deed to a blossoming plum tree";
		}

		public PlumTree4AddonDeed( Serial serial ) : base( serial )
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