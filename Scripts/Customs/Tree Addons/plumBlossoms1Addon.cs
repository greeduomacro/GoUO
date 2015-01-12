using System;
using Server;

namespace Server.Items
{
	public class PlumTree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PlumTree1AddonDeed();
			}
		}

		[Constructable]
		public PlumTree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9966 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9968 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PlumTree1Addon( Serial serial ) : base( serial )
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

	public class PlumTree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PlumTree1Addon();
			}
		}

		[Constructable]
		public PlumTree1AddonDeed()
		{
			Name = "a deed to a blossoming plum tree";
		}

		public PlumTree1AddonDeed( Serial serial ) : base( serial )
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