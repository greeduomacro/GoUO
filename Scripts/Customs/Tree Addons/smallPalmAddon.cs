using System;
using Server;

namespace Server.Items
{
	public class SmallPalmAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallPalmAddonDeed();
			}
		}

		[Constructable]
		public SmallPalmAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3225 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SmallPalmAddon( Serial serial ) : base( serial )
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

	public class SmallPalmAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallPalmAddon();
			}
		}

		[Constructable]
		public SmallPalmAddonDeed()
		{
			Name = "a deed to a small palm tree";
		}

		public SmallPalmAddonDeed( Serial serial ) : base( serial )
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