using System;
using Server;

namespace Server.Items
{
	public class PearTree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PearTree1AddonDeed();
			}
		}

		[Constructable]
		public PearTree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3496 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3497 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PearTree1Addon( Serial serial ) : base( serial )
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

	public class PearTree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PearTree1Addon();
			}
		}

		[Constructable]
		public PearTree1AddonDeed()
		{
			Name = "a deed to a pear tree";
		}

		public PearTree1AddonDeed( Serial serial ) : base( serial )
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