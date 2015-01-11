using System;
using Server;

namespace Server.Items
{
	public class DatePalmAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DatePalmAddonDeed();
			}
		}

		[Constructable]
		public DatePalmAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3222 );
			AddComponent( ac, 0, 0, 0 );

		}

		public DatePalmAddon( Serial serial ) : base( serial )
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

	public class DatePalmAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DatePalmAddon();
			}
		}

		[Constructable]
		public DatePalmAddonDeed()
		{
			Name = "a deed to a date palm";
		}

		public DatePalmAddonDeed( Serial serial ) : base( serial )
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