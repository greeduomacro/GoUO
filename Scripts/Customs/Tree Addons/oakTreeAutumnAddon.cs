using System;
using Server;

namespace Server.Items
{
	public class OakTreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OakTreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public OakTreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3295 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3293 );
			AddComponent( ac, 0, 0, 0 );

		}

		public OakTreeAutumnAddon( Serial serial ) : base( serial )
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

	public class OakTreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OakTreeAutumnAddon();
			}
		}

		[Constructable]
		public OakTreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn oak tree";
		}

		public OakTreeAutumnAddonDeed( Serial serial ) : base( serial )
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