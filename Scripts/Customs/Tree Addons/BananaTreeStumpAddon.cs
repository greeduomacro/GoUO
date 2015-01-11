using System;
using Server;

namespace Server.Items
{
	public class BananaTreeStumpAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BananaTreeStumpAddonDeed();
			}
		}

		[Constructable]
		public BananaTreeStumpAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3243 );
			AddComponent( ac, 0, 0, 0 );

		}

		public BananaTreeStumpAddon( Serial serial ) : base( serial )
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

	public class BananaTreeStumpAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BananaTreeStumpAddon();
			}
		}

		[Constructable]
		public BananaTreeStumpAddonDeed()
		{
			Name = "a deed to a stump of a banana tree";
		}

		public BananaTreeStumpAddonDeed( Serial serial ) : base( serial )
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