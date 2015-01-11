using System;
using Server;

namespace Server.Items
{
	public class OakTreeWinter2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OakTreeWinter2AddonDeed();
			}
		}

		[Constructable]
		public OakTreeWinter2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8781 );
			AddComponent( ac, 0, 0, 0 );

		}

		public OakTreeWinter2Addon( Serial serial ) : base( serial )
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

	public class OakTreeWinter2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OakTreeWinter2Addon();
			}
		}

		[Constructable]
		public OakTreeWinter2AddonDeed()
		{
			Name = "a deed to a winter oak tree";
		}

		public OakTreeWinter2AddonDeed( Serial serial ) : base( serial )
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