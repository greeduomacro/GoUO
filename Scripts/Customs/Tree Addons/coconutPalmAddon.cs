using System;
using Server;

namespace Server.Items
{
	public class CoconutPalmAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CoconutPalmAddonDeed();
			}
		}

		[Constructable]
		public CoconutPalmAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3221 );
			AddComponent( ac, 0, 0, 0 );
		}

		public CoconutPalmAddon( Serial serial ) : base( serial )
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

	public class CoconutPalmAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CoconutPalmAddon();
			}
		}

		[Constructable]
		public CoconutPalmAddonDeed()
		{
			Name = "a deed to a coconut palm";
		}

		public CoconutPalmAddonDeed( Serial serial ) : base( serial )
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