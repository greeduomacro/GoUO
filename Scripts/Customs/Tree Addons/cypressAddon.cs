using System;
using Server;

namespace Server.Items
{
	public class CypressAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CypressAddonDeed();
			}
		}

		[Constructable]
		public CypressAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3324 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3323 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CypressAddon( Serial serial ) : base( serial )
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

	public class CypressAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CypressAddon();
			}
		}

		[Constructable]
		public CypressAddonDeed()
		{
			Name = "a deed to a cypress tree";
		}

		public CypressAddonDeed( Serial serial ) : base( serial )
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