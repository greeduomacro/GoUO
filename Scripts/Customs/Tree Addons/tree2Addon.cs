using System;
using Server;

namespace Server.Items
{
	public class Tree2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Tree2AddonDeed();
			}
		}

		[Constructable]
		public Tree2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3284 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3283 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Tree2Addon( Serial serial ) : base( serial )
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

	public class Tree2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Tree2Addon();
			}
		}

		[Constructable]
		public Tree2AddonDeed()
		{
			Name = "a deed to a tree";
		}

		public Tree2AddonDeed( Serial serial ) : base( serial )
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