using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class HiddenEgg : Item
	{
	
		public override void OnDoubleClick( Mobile from )
		{
			if (!from.InRange( this.GetWorldLocation(), 1 ))
			{
				from.SendMessage( "I can't reach that." );
				return;
			}
			
			PlayerMobile pm = (PlayerMobile) from;
			EasterEgg egg = new EasterEgg();
			
			pm.Direction = pm.GetDirectionTo( this );
			pm.Animate( 32, 5, 1, true, false, 0 );
			pm.SendMessage("You have found an egg!");
			int randomegg = Utility.Random( 10 );
			if (randomegg <= 5)
			{
				//small egg
				egg.ItemID = Utility.RandomList(0x23ab, 0x23ac, 0x23ad); //customs
				//egg.ItemID = 0x41bd; //SA graphic
				egg.Hue = Hue;
			}
			else if (randomegg > 5 && randomegg <= 9)
			{
				//medium egg
				egg.ItemID = Utility.RandomList(0x23ae, 0x23af); //customs
				//egg.ItemID = 0x41be; //SA graphic
				egg.Hue = Hue;
			}
			else
			{
				//large egg
				egg.ItemID = Utility.RandomList(0x23b0); //customs
				//egg.ItemID = 0x41bf; //SA graphic
				egg.Hue = Hue;
			}
			pm.AddToBackpack(egg);
			this.Delete();
		}
		
		[Constructable]
		public HiddenEgg() : base( 0x0cac )
		{
			Name = "grasses";
			Movable = false;
			Hue = Utility.RandomList(1163, 1164, 1166, 1172, 1173, 1193, 1194);
			ItemID = Utility.RandomList(0x23b1, 0x23b2, 0x23b3, 0x23b4, 0x23b5, 0x23b6, 0x23b7); //custom set
			//ItemID = Utility.RandomList(0x0CAC, 0x0CAD, 0x0CAE, 0x0CAF, 0x0CB0, 0x0CB1, 0x0CB2); //original set
		}
		
		public HiddenEgg( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}