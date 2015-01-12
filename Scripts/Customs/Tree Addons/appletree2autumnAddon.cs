using System;
using Server;

namespace Server.Items
{
	public class AppleTree2AutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AppleTree2AutumnAddonDeed();
			}
		}

		[Constructable]
		public AppleTree2AutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3479 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3476 );
			AddComponent( ac, 0, 0, 0 );
		}

		public AppleTree2AutumnAddon( Serial serial ) : base( serial )
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

	public class AppleTree2AutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AppleTree2AutumnAddon();
			}
		}

		[Constructable]
		public AppleTree2AutumnAddonDeed()
		{
			Name = "a deed to an autumn apple tree";
		}

		public AppleTree2AutumnAddonDeed( Serial serial ) : base( serial )
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