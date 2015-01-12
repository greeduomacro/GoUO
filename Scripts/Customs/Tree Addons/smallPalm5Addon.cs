using System;
using Server;

namespace Server.Items
{
	public class SmallPalm5Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallPalm5AddonDeed();
			}
		}

		[Constructable]
		public SmallPalm5Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3229 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SmallPalm5Addon( Serial serial ) : base( serial )
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

	public class SmallPalm5AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallPalm5Addon();
			}
		}

		[Constructable]
		public SmallPalm5AddonDeed()
		{
			Name = "a deed to a small palm tree";
		}

		public SmallPalm5AddonDeed( Serial serial ) : base( serial )
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