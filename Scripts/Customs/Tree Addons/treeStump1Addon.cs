using System;
using Server;

namespace Server.Items
{
	public class TreeStump1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeStump1AddonDeed();
			}
		}

		[Constructable]
		public TreeStump1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3501 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeStump1Addon( Serial serial ) : base( serial )
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

	public class TreeStump1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeStump1Addon();
			}
		}

		[Constructable]
		public TreeStump1AddonDeed()
		{
			Name = "a deed to a tree stump";
		}

		public TreeStump1AddonDeed( Serial serial ) : base( serial )
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