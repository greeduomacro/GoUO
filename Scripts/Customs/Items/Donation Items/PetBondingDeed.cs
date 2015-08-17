// Designed By: EternaL
// Part of the Armagedon scripts
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Items
{
	public class BondingTarget : Target
	{
		private PetBondingDeed m_Deed;
		
		public BondingTarget( PetBondingDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			if ( target is BaseCreature )
			{
				BaseCreature t = ( BaseCreature ) target;
				
				if ( t.IsBonded == true )
				{
					from.SendMessage( "That pet is already bonded!" );
				}
				else if ( t.ControlMaster != from )
				{
					from.SendMessage( "That is not your pet!" );
				}
				else
					
				{
					
					t.IsBonded = !t.IsBonded;
					from.SendMessage( "You bond with the pet!" );
					
					m_Deed.Delete(); // Delete the deed
				}
				
			}
			else
			{
				from.SendMessage( "That is not a valid traget." );
			}
		}
	}
	
	public class PetBondingDeed : Item // Create the item class which is derived from the base item class
	{
		[Constructable]
		public PetBondingDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "a pet bonding deed";
			Hue = 572;
		}
		
		public PetBondingDeed( Serial serial ) : base( serial )
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
		
		public override bool DisplayLootType{ get{ return false; } }
		
		public override void OnDoubleClick( Mobile from ) // Override double click of the deed to call our target
		{
			if ( !IsChildOf( from.Backpack ) ) // Make sure its in their pack
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else
			{
				from.SendMessage( "Choose the pet you wish to bond with." );
				from.Target = new BondingTarget( this ); // Call our target
			}
		}
	}
}
