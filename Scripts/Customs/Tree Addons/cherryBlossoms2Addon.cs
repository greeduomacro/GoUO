using System;
using Server;

namespace Server.Items
{
	public class CherryTree2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CherryTree2AddonDeed();
			}
		}

		[Constructable]
		public CherryTree2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9331 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9334 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CherryTree2Addon( Serial serial ) : base( serial )
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

	public class CherryTree2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CherryTree2Addon();
			}
		}

		[Constructable]
		public CherryTree2AddonDeed()
		{
			Name = "a deed to a blossoming cherry tree";
		}

		public CherryTree2AddonDeed( Serial serial ) : base( serial )
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