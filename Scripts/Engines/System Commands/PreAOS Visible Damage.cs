using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server
{
    public class PreAOS
    {
        private const bool Enabled = true;

        public static void Configure()
        {
            Mobile.VisibleDamageType = Enabled ? VisibleDamageType.Related : VisibleDamageType.None;
        }
    }
}