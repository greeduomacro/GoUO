using System;
using Server;

namespace Server.Items
{
	public class TuscanyPineAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TuscanyPineAddonDeed();
			}
		}

		[Constructable]
		public TuscanyPineAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 7038 );
			AddComponent( ac, 0, 0, 0 );

		}

		public TuscanyPineAddon( Serial serial ) : base( serial )
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

	public class TuscanyPineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TuscanyPineAddon();
			}
		}

		[Constructable]
		public TuscanyPineAddonDeed()
		{
			Name = "a deed to a tuscany pine tree";
		}

		public TuscanyPineAddonDeed( Serial serial ) : base( serial )
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