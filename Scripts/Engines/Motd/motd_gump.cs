//===================================)
//Written by Steven Dorman for the Morbid Visions shard)
//===================================)
//                 http://mvgame.0web.uni.cc                      )
//===================================)

using System;
using Server.Network;
using Server.Gumps;
using System.Collections;
using System.IO;
using Server.Mobiles;
using Server.Items;
namespace Server.Gumps
{
	public class motdg : Gump
	{
		public motdg()
			: base( 0, 0 )
		{

			string filename = Path.Combine( Core.BaseDirectory, "Data/motd.html" );
			string fullfile = "";
			
			if ( File.Exists( filename ) )
			{
				using ( StreamReader sr = new StreamReader( filename ) )
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						fullfile = fullfile + line;	
					}
				}
				
				
				if ( fullfile != null || fullfile != "" )
				{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddImage(28, 69, 1231);
			this.AddImage(43, 25, 39);
			this.AddHtml( 68, 72, 200, 215, @"" + fullfile, (bool)false, (bool)false);
			this.AddButton(242, 288, 1153, 1155, 101, GumpButtonType.Reply, 0);
			this.AddLabel(71, 49, 489, @"Message of the Day");
				}
				else
				{
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddImage(28, 69, 1231);
			this.AddImage(43, 25, 39);
			this.AddHtml( 68, 72, 200, 215, @"There is no message of the day." , (bool)false, (bool)false);
			this.AddButton(242, 288, 1153, 1155, 101, GumpButtonType.Reply, 0);
			this.AddLabel(71, 49, 489, @"Message of the Day");
				}
			}
			else
			{
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddImage(28, 69, 1231);
			this.AddImage(43, 25, 39);
			this.AddHtml( 68, 72, 200, 215, @"<u>Error:</u><br>Could not find MOTD File.", (bool)false, (bool)false);
			this.AddButton(242, 288, 1153, 1155, 101, GumpButtonType.Reply, 0);
			this.AddLabel(71, 49, 489, @"Message of the Day");
			}


		

		}
		
		public override void OnResponse( NetState sender, RelayInfo info )
		{
			Mobile m = sender.Mobile;
			if ( m == null )
			return;

			switch ( info.ButtonID )
			{
			
				case 101:
				{
					m.CloseGump(typeof(motdg) ); 
					break;
				}					
			
			}
		}
		

	}
}