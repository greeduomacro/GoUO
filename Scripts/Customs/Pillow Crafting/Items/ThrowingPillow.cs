// 15AUG2007 written by RavonTUS
//
//   /\\           |\\  ||
//  /__\\  |\\ ||  | \\ ||  /\\  \ //
// /    \\ | \\||  |  \\||  \//  / \\ 
// Play at An Nox, the cure for the UO addiction
// http://annox.no-ip.com  // RavonTUS@Yahoo.com
/*
 * Created by SharpDevelop.
 * User: alexanderfb
 * Date: 1/25/2005
 * Time: 10:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using Server;
using Server.Targeting;

namespace Server.Items
{
    [Flipable(0x13AB, 0x13AC)]
    public class ThrowingPillow : Item, IDyable
    {
        [Constructable]
        public ThrowingPillow()
            : base(0x13AB)
        {
            Name = "a throwing pillow";
        }


        public override void OnDoubleClick(Mobile from)
        {
                InternalTarget t = new InternalTarget(this);
                from.Target = t;
        }

        private class InternalTarget : Target
        {
            private ThrowingPillow m_Pillow;

            public InternalTarget(ThrowingPillow Pillow)
                : base(10, false, TargetFlags.Harmful)
            {
                m_Pillow = Pillow;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (m_Pillow.Deleted)
                {
                    return;
                }
                else if (targeted is Mobile)
                {
                    Mobile m = (Mobile)targeted;

                    //Effects.SendLocationEffect(m.Location, m.Map, 0x3728, 20, 10); //smoke or dust
					
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y, m.Z + 4), m.Map, 0x3728, 13);
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y, m.Z), m.Map, 0x36BD, 13);
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y, m.Z - 4), m.Map, 0x3728, 13);
					Effects.SendLocationEffect(new Point3D(m.X, m.Y + 1, m.Z + 4), m.Map, 0x3728, 13);
					Effects.SendLocationEffect(new Point3D(m.X, m.Y + 1, m.Z), m.Map, 0x36BD, 13);
					Effects.SendLocationEffect(new Point3D(m.X, m.Y + 1, m.Z - 4), m.Map, 0x3728, 13);
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z + 11), m.Map, 0x3728, 13);
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z + 7), m.Map, 0x3728, 13);
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z + 3), m.Map, 0x36BD, 13);
					Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z - 1), m.Map, 0x3728, 13);					
					
                    Effects.PlaySound(m.Location, m.Map, 0x307);
					
                    new Feather().MoveToWorld(m.Location, m.Map);
                    new Feather().MoveToWorld(m.Location, m.Map);
                    new Feather().MoveToWorld(m.Location, m.Map);
                    new Feather().MoveToWorld(m.Location, m.Map);
                    new Feather().MoveToWorld(m.Location, m.Map);
                  
                }

		m_Pillow.Delete();
            }
        }
        public ThrowingPillow(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public bool Dye(Mobile from, DyeTub sender)
        {
            if (Deleted)
                return false;

            Hue = sender.DyedHue;

            return true;
        }
    }
}
