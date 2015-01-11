using System;
using Server;

namespace Server.Items
{
	public class OakTreeWinterAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OakTreeWinterAddonDeed();
			}
		}

		[Constructable]
		public OakTreeWinterAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8780 );
			AddComponent( ac, 0, 0, 0 );

		}

		public OakTreeWinterAddon( Serial serial ) : base( serial )
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

	public class OakTreeWinterAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OakTreeWinterAddon();
			}
		}

		[Constructable]
		public OakTreeWinterAddonDeed()
		{
			Name = "a deed to a winter oak tree";
		}

		public OakTreeWinterAddonDeed( Serial serial ) : base( serial )
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