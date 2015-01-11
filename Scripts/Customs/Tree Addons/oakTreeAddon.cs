using System;
using Server;

namespace Server.Items
{
	public class OakTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OakTreeAddonDeed();
			}
		}

		[Constructable]
		public OakTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3291 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3290 );
			AddComponent( ac, 0, 0, 0 );

		}

		public OakTreeAddon( Serial serial ) : base( serial )
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

	public class OakTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OakTreeAddon();
			}
		}

		[Constructable]
		public OakTreeAddonDeed()
		{
			Name = "a deed to an oak tree";
		}

		public OakTreeAddonDeed( Serial serial ) : base( serial )
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