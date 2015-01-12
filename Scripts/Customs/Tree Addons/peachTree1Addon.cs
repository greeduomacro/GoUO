using System;
using Server;

namespace Server.Items
{
	public class PeachTree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PeachTree1AddonDeed();
			}
		}

		[Constructable]
		public PeachTree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3489 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3488 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PeachTree1Addon( Serial serial ) : base( serial )
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

	public class PeachTree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PeachTree1Addon();
			}
		}

		[Constructable]
		public PeachTree1AddonDeed()
		{
			Name = "a deed to a peach tree";
		}

		public PeachTree1AddonDeed( Serial serial ) : base( serial )
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