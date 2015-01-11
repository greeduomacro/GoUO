using System;
using Server;

namespace Server.Items
{
	public class TreeAutumnAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreeAutumnAddonDeed();
			}
		}

		[Constructable]
		public TreeAutumnAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3279 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3276 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TreeAutumnAddon( Serial serial ) : base( serial )
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

	public class TreeAutumnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreeAutumnAddon();
			}
		}

		[Constructable]
		public TreeAutumnAddonDeed()
		{
			Name = "a deed to an autumn tree";
		}

		public TreeAutumnAddonDeed( Serial serial ) : base( serial )
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