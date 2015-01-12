using System;
using Server;

namespace Server.Items
{
	public class Tree1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Tree1AddonDeed();
			}
		}

		[Constructable]
		public Tree1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3281 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3280 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Tree1Addon( Serial serial ) : base( serial )
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

	public class Tree1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Tree1Addon();
			}
		}

		[Constructable]
		public Tree1AddonDeed()
		{
			Name = "a deed to a tree";
		}

		public Tree1AddonDeed( Serial serial ) : base( serial )
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