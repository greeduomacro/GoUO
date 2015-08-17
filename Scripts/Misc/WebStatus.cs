using System;
using System.IO;
using System.Text;
using System.Collections;
using Server;
using Server.Network;
using Server.Guilds;
using Server.Mobiles;

namespace Server.CurseWebsite
{
	public class StatusPage : Timer
	{
		public static bool Enabled = false;

		public static void Initialize()
		{
			if ( Enabled )
				new StatusPage().Start();
		}

		public StatusPage() : base( TimeSpan.FromSeconds( 5.0 ), TimeSpan.FromSeconds( 10.0 ) )
		{
			Priority = TimerPriority.FiveSeconds;
		}

		private static string Encode( string input )
		{
			StringBuilder sb = new StringBuilder( input );

			sb.Replace( "&", "&amp;" );
			sb.Replace( "<", "&lt;" );
			sb.Replace( ">", "&gt;" );
			sb.Replace( "\"", "&quot;" );
			sb.Replace( "'", "&apos;" );

			return sb.ToString();
		}

		protected override void OnTick()
		{
		/*
			if ( !Directory.Exists( "web" ) )
				Directory.CreateDirectory( "web" );
        */
			using ( StreamWriter op = new StreamWriter( "C:/xampp/htdocs/status.html" ) )
			{
		     op.WriteLine( "<html>" );
		     op.WriteLine( "   <head>" );
		     op.WriteLine( "      <title>UnmixedUO</title>");
		     op.WriteLine( "   </head>" );


                     op.WriteLine( "      <table border=\"6\" cellpadding=\"4\" width=\"100%\"><tr>" );
                     op.WriteLine( "      <p align=\"center\"><font color=\"white\" size=\"1\" face=\"Black Chancery,Arial,Helvetica\"><strong>This information is updated in real time from the server every 10 seconds</font><br>" );
                     op.WriteLine( "      <p align=\"center\" ><font size=\"1\" face=\"Black Chancery,Arial,Helvetica\" color=\"white\"><strong> Last Updated: {0:F} <br>",System.DateTime.Now); 
                     op.WriteLine( "      <p align=\"left\"><font size=\"2\" color=\"#2b485c\" face=\"Black Chancery,Arial,Helvetica\"><strong>Administrator:</font><font size=\"2\" color=\"white\" face=\"Black Chancery,Arial,Helvetica\"> Zycron</font></strong><br><font size=\"2\" color=\"#2b485c\" face=\"Black Chancery,Arial,Helvetica\"><strong>Email: </strong></font><a href=\"mailto:zycron@gouo.org\">  zycron@gouo<br></a></font><font size=\"1\" color=\"white\" face=\"Black Chancery,Arial,Helvetica\"><strong>Server Version: </strong></font><font size=\"1\" color=\"white\" face=\"Black Chancery,Arial,Helvetica\">GoUO 1.0<br></font></p>" );
                     op.WriteLine( "      <div align=\"left\">" );  
                     op.WriteLine( "      <tr><td width=\"33%\"></td><td width=\"33%\"></td></tr>" ); 
                     op.WriteLine( "      </table><br>" );
		     op.WriteLine( "   	  <body bgcolor=\"#222222\">" );
		     op.WriteLine( "      <h1><p align=\"center\"><font color=\"#2b485c\">Server Status</font></td></h1>" );
                     op.WriteLine( "      <div align=\"left\">" ); 
                     op.WriteLine( "      <tr><td width=\"33%\"></td><td width=\"33%\"></td></tr>" ); 
                     op.WriteLine( "      </table><br>" );
                     op.WriteLine( "      <table border=\"6\" cellpadding=\"4\" width=\"100%\"><tr>" ); 
                     op.WriteLine( "      <td nowrap colspan=\"2\" bgcolor=\"#222222\"><strong><font face=\"Black Chancery,Arial,Helvetica\" size=\"2\" color=\"#2b485c\">Statistics</font></strong></td></tr>" );
                     op.WriteLine( "      <tr><td nowrap width=\"5%\" bgcolor=\"#222222\"><font face=\"Black Chancery,Arial,Helvetica\" size=\"2\" color=\"#ffffff\">Mobiles</font></td><td width=\"95%\" bgcolor=\"#222222\"><font face=\"Black Chancery,Arial,Helvetica\" size=\"2\" color=\"#ffffff\">{0}</font></td></tr>",World.Mobiles.Count.ToString() );
                     op.WriteLine( "      <tr><td nowrap bgcolor=\"#222222\" width=\"5%\"><font face=\"Black Chancery,Arial,Helvetica\" size=\"2\" color=\"#ffffff\">Items</font></td><td bgcolor=\"#222222\" width=\"95%\"><font face=\"Black Chancery,Arial,Helvetica\" size=\"2\" color=\"#ffffff\">{0}</font></td></tr>",World.Items.Count.ToString() );
		     op.WriteLine( "      <table width=\"100%\">" );
                     op.WriteLine( "      <tr><td width=\"33%\"></td><td width=\"33%\"></td></tr>" ); 
                     op.WriteLine( "      </table><br>" );
                     op.WriteLine( "      <table border=\"6\" cellpadding=\"4\" width=\"100%\"><tr>" );
		     op.WriteLine( "      <font color=\"#2b485c\">Online clients:</font></td><br>" );
		     op.WriteLine( "            <td bgcolor=\"#222222\"><font color=\"white\">Name</font></td><td bgcolor=\"#222222\"><font color=\"white\">Young Status</font></td><td bgcolor=\"#222222\"><font color=\"white\">Live or Dead</font></td><td bgcolor=\"#222222\"><font color=\"white\">Title</font></td><td bgcolor=\"#222222\"><font color=\"white\">Map</font></td><td bgcolor=\"#222222\"><font color=\"white\">Region</font></td><td bgcolor=\"#222222\"><font color=\"white\">Kills</font></td><td bgcolor=\"#222222\"><font color=\"white\">Karma / Fame</font></td>" );
		     op.WriteLine( "            <td bgcolor=\"#222222\"><font color=\"white\">Strength</font></td><td bgcolor=\"#222222\"><font color=\"white\">Dexterity</font></td><td bgcolor=\"#222222\"><font color=\"white\">Intelligence</font></td><td bgcolor=\"#222222\"><font color=\"white\">Hits / Hits Max</font></td><td bgcolor=\"#222222\"><font color=\"white\">ControlSlots Used</font></td>" );


                     				op.WriteLine( "         <tr>" );

				foreach ( NetState state in NetState.Instances )
				{
					Mobile m = state.Mobile;

					if ( m != null && m.AccessLevel < AccessLevel.Owner )
					{
						string serial = m.Serial.Value.ToString();
						Guild g = m.Guild as Guild;

						op.Write( "         <tr><td><font color=\"#2b485c\">" );

						if ( g != null )
						{
							op.Write( "<a href =\"" + Encode( m.Name ) + serial + ".html\"target=\"_blank\">" + Encode( m.Name ) + "</a>" );
							op.Write( " [" );

							string title = m.GuildTitle;

							if ( title != null )
								title = title.Trim();
							else
								title = "";

							if ( title.Length > 0 )
							{
								op.Write( Encode( title ) );
								op.Write( ", " );
							}

							op.Write( Encode( g.Abbreviation ) );

							op.Write( ']' );
						}
						else
						{
							op.Write( "<a href =\"" + Encode( m.Name ) + serial + ".html\"target=\"_blank\">" + Encode( m.Name ) + "</a>" );
						}
						op.Write( "</td><td>" ); 
						if (m is PlayerMobile && ((PlayerMobile)m).Young)
						{
						op.Write( "<font color=\"purple\">" );
						op.Write("(Young)");
						}
						else if (m is PlayerMobile && !((PlayerMobile)m).Young)
						{
						op.Write( "<font color=\"green\">" );
						op.Write("(Old Timer)");
						}
						op.Write( "</td><td>" ); 
						if (m is PlayerMobile && m.Alive)
						{
						op.Write( "<font color=\"white\">" );
						op.Write("Alive");
						}
						else if (m is PlayerMobile && !m.Alive)
						{
						op.Write( "<font color=\"grey\">" );
						op.Write("Dead");
						}
						op.Write( "</td><td>" );
						op.Write( "<font color=\"gold\">" );
						op.Write( m.Title );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"darkorange\">" );
						op.Write( m.Map );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"darkorange\">" );
						op.Write( m.Region );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"red\">" );
						op.Write( m.Kills );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"yellow\">" );
						op.Write( m.Karma );
						op.Write( "/<font color=\"yellow\">" );
						op.Write( m.Fame ); 
						op.WriteLine( "</td></td>" );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"cyan\">" );
						op.Write( m.RawStr );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"cyan\">" );
						op.Write( m.RawDex );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"cyan\">" );
						op.Write( m.RawInt );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"blue\">" );
						op.Write( m.Hits );
						op.Write( "/<font color=\"blue\">" );
						op.Write( m.HitsMax );
						op.Write( "</td><td>" );
						op.Write( "<font color=\"tan\">" );
						op.Write( m.Followers );
						op.WriteLine( "</td></tr>" );

					}
				}

						op.WriteLine( "         <tr>" );
						op.WriteLine( "      </table>" );
						op.WriteLine( "</h1><h1  align=\"center\"><img border=\"0\" src=\"logo.png\">" );
            					op.WriteLine( " <META HTTP-EQUIV=\"REFRESH\" CONTENT=\"10\"> " );
						op.WriteLine( "   </body>" );
						op.WriteLine( "</html>" );
			}
		}
	}
}