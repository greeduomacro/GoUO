using System;
using System.Reflection;
using Server.Items;
using Server.Targeting;
using Server.Gumps;
using Server.Mobiles;
using Server.Commands;

namespace Server.Scripts.commands
{
	public class motd
	{
		public static void Initialize()
		{
			CommandSystem.Register( "motd", AccessLevel.GameMaster, new CommandEventHandler( onmotd ) );
			
		}

		
		[Usage( "motd" )]
		[Description( "Displays The Message Of The Day" )]
		private static void onmotd( CommandEventArgs e )
		{
			e.Mobile.SendGump(new motdg());
		}
		
	}
}
