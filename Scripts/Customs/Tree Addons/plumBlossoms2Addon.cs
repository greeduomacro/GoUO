using System;
using Server;

namespace Server.Items
{
	public class PlumTree2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PlumTree2AddonDeed();
			}
		}

		[Constructable]
		public PlumTree2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9965 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9969 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PlumTree2Addon( Serial serial ) : base( serial )
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

	public class PlumTree2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PlumTree2Addon();
			}
		}

		[Constructable]
		public PlumTree2AddonDeed()
		{
			Name = "a deed to a blossoming plum tree";
		}

		public PlumTree2AddonDeed( Serial serial ) : base( serial )
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