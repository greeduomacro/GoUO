using System;
using Server;

namespace Server.Items
{
	public class Tree2AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Tree2AutumnAddonDeed();
			}
		}

		[Constructable]
		public Tree2AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3285 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3283 );
			AddComponent( ac, 0, 0, 0 );

		}

		public Tree2AutumnAddon( Serial serial ) : base( serial )
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

	public class Tree2AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Tree2AutumnAddon();
			}
		}

		[Constructable]
		public Tree2AutumnAddonDeed()
		{
			Name = "a deed to an autumn tree";
		}

		public Tree2AutumnAddonDeed( Serial serial ) : base( serial )
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