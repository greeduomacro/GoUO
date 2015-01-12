using System; 
using Server.Network; 
using Server.Targeting; 
using Server.Items; 

namespace Server.Items 
{ 

   public class PoisonHide : BaseGMJewel 
   { 
    
      [Constructable] 
      public PoisonHide() : base(AccessLevel.GameMaster, 0x845, 0xF8E ) 
      { 
      Name = "GM Poison Ball"; 
      } 
      public PoisonHide( Serial serial ) : base( serial ) 
      { 
      } 

      public override void OnDoubleClick( Mobile from ) 
      { 
      
      if ( Parent != from ) 
      if (from.AccessLevel < AccessLevel.GameMaster) 
          from.SendMessage( "When you touch, it vanishes without trace..." ); 
      if (from.AccessLevel < AccessLevel.GameMaster) 
         this.Consume() ; 
      if (from.AccessLevel < AccessLevel.GameMaster)    
         return ; 
      { 
                      
          if ( !from.Hidden == true ) 
            { 
           from.FixedParticles( 0x36CB, 1, 9, 9911, 67, 5, EffectLayer.Head ); 
           from.FixedParticles( 0x374A, 1, 17, 9502, 1108, 4, (EffectLayer)255 ); 
         from.PlaySound( 0x22F ); 
          from.Hidden = true; 
            
            } 
            else 
            { 
           from.Hidden=false; 
           from.FixedParticles( 0x36CB, 1, 9, 9911, 67, 5, EffectLayer.Head ); 
           from.FixedParticles( 0x374A, 1, 17, 9502, 1108, 4, (EffectLayer)255 ); 
         from.PlaySound( 0x22F ); 

                      
            } 
      } 

      
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