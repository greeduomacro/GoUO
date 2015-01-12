using System;
using Server;

namespace Server.Items
{
	public class YuccaTree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new YuccaTree1AddonDeed();
			}
		}

		[Constructable]
		public YuccaTree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3384 );
			AddComponent( ac, 0, 0, 0 );

		}

		public YuccaTree1Addon( Serial serial ) : base( serial )
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

	public class YuccaTree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new YuccaTree1Addon();
			}
		}

		[Constructable]
		public YuccaTree1AddonDeed()
		{
			Name = "a deed to a yucca tree";
		}

		public YuccaTree1AddonDeed( Serial serial ) : base( serial )
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