using System;
using Server;

namespace Server.Items
{
	public class OakTreeGrownAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OakTreeGrownAddonDeed();
			}
		}

		[Constructable]
		public OakTreeGrownAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3293 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3294 );
			AddComponent( ac, 0, 0, 0 );

		}

		public OakTreeGrownAddon( Serial serial ) : base( serial )
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

	public class OakTreeGrownAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OakTreeGrownAddon();
			}
		}

		[Constructable]
		public OakTreeGrownAddonDeed()
		{
			Name = "a deed to a grown oak tree";
		}

		public OakTreeGrownAddonDeed( Serial serial ) : base( serial )
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