using System;
using Server;

namespace Server.Items
{
	public class Tree1AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Tree1AutumnAddonDeed();
			}
		}

		[Constructable]
		public Tree1AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3282 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3280 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Tree1AutumnAddon( Serial serial ) : base( serial )
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

	public class Tree1AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Tree1AutumnAddon();
			}
		}

		[Constructable]
		public Tree1AutumnAddonDeed()
		{
			Name = "a deed to an autumn tree";
		}

		public Tree1AutumnAddonDeed( Serial serial ) : base( serial )
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