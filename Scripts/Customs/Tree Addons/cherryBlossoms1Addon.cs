using System;
using Server;

namespace Server.Items
{
	public class CherryTree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CherryTree1AddonDeed();
			}
		}

		[Constructable]
		public CherryTree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9330 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9334 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CherryTree1Addon( Serial serial ) : base( serial )
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

	public class CherryTree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CherryTree1Addon();
			}
		}

		[Constructable]
		public CherryTree1AddonDeed()
		{
			Name = "a deed to a blossoming cherry tree";
		}

		public CherryTree1AddonDeed( Serial serial ) : base( serial )
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