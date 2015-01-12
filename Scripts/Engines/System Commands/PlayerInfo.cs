using System;
using System.Collections.Generic;
using System.Text;
using Server;
using Server.Misc;
using Server.Items;
using Server.Gumps;
using Server.Mobiles;
using Server.ContextMenus;
using Server.Accounting;
using Server.Factions;
using Server.Engines;
using Server.Engines.ConPVP;
using Server.Guilds;
using Server.Ethics;
 
namespace Server {
	public abstract class BaseDetailGump : Gump {
		protected const int WhiteColor32 = 0xFFFFFF;
		protected const int BlackColor32 = 0x000000;
 
		protected const int LabelColor32 = 0xCC9933;
		protected const int FocusColor32 = 0xFFEEDD;
 
		protected string Center( string text ) {
			return String.Format( "<CENTER>{0}</CENTER>", text );
		}
 
		protected string Color( string text, int color ) {
			return String.Format( "<BASEFONT COLOR=#{0:X6}>{1}</BASEFONT>", color, text );
		}
 
		protected string Right( string text ) {
			return String.Format( "<DIV ALIGN=RIGHT>{0}</DIV>", text );
		}
 
		protected void AddBorderedText( int x, int y, int width, int height, string text, int color, int borderColor )
		{
			AddColoredText( x - 1, y, width, height, text, borderColor );
			AddColoredText( x + 1, y, width, height, text, borderColor );
			AddColoredText( x, y - 1, width, height, text, borderColor );
			AddColoredText( x, y + 1, width, height, text, borderColor );
			AddColoredText( x, y, width, height, text, color );
		}
 
		protected void AddColoredText( int x, int y, int width, int height, string text, int color )
		{
			if ( color == 0 ) {
				AddHtml( x, y, width, height, text, false, false );
			} else {
				AddHtml( x, y, width, height, Color( text, color ), false, false );
			}
		}
 
		protected void AddSeperator( int x, int y, int width )
		{
			AddImageTiled( x, y, width - 6, 1, 9107 );
			AddImageTiled( x + 6, y + 2, width - 6, 1, 9157 );
		}
 
		private GumpBackground _back;
		private GumpAlphaRegion _alpha;
 
		public int Width {
			get {
				return _back.Width;
			}
			set {
				_back.Width = value;
				_alpha.Width = value - 20;
			}
		}
 
		public int Height {
			get {
				return _back.Height;
			}
			set {
				_back.Height = value;
				_alpha.Height = value - 20;
			}
		}
 
		protected BaseDetailGump()
			: base( 50, 50 ) {
			AddPage( 0 );
			
 
			/*AddBackground( 1, 1, 398, 218 + 102, 3600 );
			AddImageTiled( 16, 15, 369, 189 + 102, 3604 );
			AddAlphaRegion( 16, 15, 369, 189 + 102 );*/
 
			Add( _back = new GumpBackground( 0, 0, 300, 200, 9270 ) );
			Add( _alpha = new GumpAlphaRegion( 10, 10, 300 - 20, 200 - 20 ) );
		}
	}
 
	public sealed class PlayerInfoContextEntry : ContextMenuEntry {
		private PlayerMobile _from;
		private PlayerMobile _mobile;
 
		public PlayerInfoContextEntry( PlayerMobile from, PlayerMobile mobile )
			: base( 5000, 12 ) {
			_from = from;
			_mobile = mobile;
		}
 
		public override void OnClick() {
			base.OnClick();
 
			_from.CloseGump( typeof( PlayerDetailGump ) );
			_from.SendGump( new PlayerDetailGump( _from, _mobile ) );
		}
	}
 
	public sealed class PlayerDetailGump : BaseDetailGump {
		private PlayerMobile _from;
		private PlayerMobile _mobile;
 
		private static int[] _notorietyColors = new int[] {
			0xFFFFFF,
			0x33FFFF,
			0x33FF33,
			0x999999,
			0x999999,
			0xFF9933,
			0xCC3333,
			0xFFFF33
		};
 
		public PlayerDetailGump( PlayerMobile from, PlayerMobile mobile ) {
			_from = from;
			_mobile = mobile;
 
			Width = 320;
 
			int n = Notoriety.Compute( from, mobile );
 
			int notoColor = _notorietyColors[n];
 
			AddBorderedText( 20, 18, Width - 40, 20, Center( mobile.Name ?? "Unknown" ), notoColor, BlackColor32 );
 
			AddSeperator( 30, 40, Width - 60 );
 
			const int LabelOffset = 20;
			const int LabelWidth = 55;
 
			const int ValueOffset = 25 + LabelWidth;
			int ValueWidth = Width - ( 20 + ValueOffset );
 
			int y = 44;
 
			PlayerMobile pm = mobile as PlayerMobile;
 
			Guild guild = mobile.Guild as Guild;
 
			if ( guild != null ) {
				AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Guild:" ), LabelColor32, BlackColor32 );
 
				AddBorderedText( ValueOffset, y, ValueWidth, 20, guild.Name ?? "Unknown", WhiteColor32, BlackColor32 );
				y += 20;
			}
 
			if ( mobile.PublicMyRunUO && mobile.Kills >= 5 ) {
				AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Kills:" ), LabelColor32, BlackColor32 );
				AddBorderedText( ValueOffset, y, ValueWidth, 20, mobile.Kills.ToString( "N0" ), WhiteColor32, BlackColor32 );
 
				y += 20;
			}
 
			Account acct = mobile.Account as Account;
 
			if ( acct != null ) {
				TimeSpan age = DateTime.UtcNow - acct.Created;
 
				int ageInDays = ( int ) age.TotalDays;
 
				int ageInYears = ( ( ageInDays + 162 ) / 365 );
				int ageInMonths = ( ( ageInDays + 15 ) / 30 );
				int ageInWeeks = ( ( ageInDays + 3 ) / 7 );
 
				string ageString;
 
				if ( ageInYears > 0 ) {
					ageString = String.Format( "{0:N0} year{1}", ageInYears, ageInYears==1?"":"s" );
				} else if ( ageInMonths > 1 ) {
					ageString = String.Format( "{0:N0} month{1}", ageInMonths, ageInMonths==1?"":"s" );
				} else if ( ageInWeeks > 1 ) {
					ageString = String.Format( "{0:N0} week{1}", ageInWeeks, ageInWeeks==1?"":"s" );
				} else {
					ageString = String.Format( "Newbie", ageInDays, ageInDays==1?"":"s" );
				}
				
					
 
				AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Age:" ), LabelColor32, BlackColor32 );
				AddBorderedText( ValueOffset, y, ValueWidth, 20, ageString, WhiteColor32, BlackColor32 );
 
				y += 20;
			}
	
			PlayerState ps = PlayerState.Find( mobile );
 
			if ( ps != null ) {
				Faction fac = ps.Faction;
 
				//AddItem( Width - 51, 7, 5535, (fac.Definition.HueSecondary ^ 0x0000) - 1 );
				AddItem( 7, 7, 5534, ( fac.Definition.HuePrimary ^ 0x0000 ) - 1 );
 
				y += 8;
 
				AddBorderedText( LabelOffset, y, LabelWidth + ValueWidth, 20, fac.Definition.FriendlyName, WhiteColor32, BlackColor32 );
 
				y += 21;
				AddSeperator( 30, y, Width - 60 );
				y += 3;
 
				string rank = String.Format(
					"Level {0} {1}",
					ps.Rank.Rank,
					ps.Rank.Title.String
				);
 
				AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Rank:" ), LabelColor32, BlackColor32 );
				AddBorderedText( ValueOffset, y, ValueWidth, 20, rank, WhiteColor32, BlackColor32 );
				y += 20;
 
				AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Points:" ), LabelColor32, BlackColor32 );
				AddBorderedText( ValueOffset, y, ValueWidth, 20, String.Format( "{0:N0}", ps.KillPoints ), WhiteColor32, BlackColor32 );
				y += 20;
			}
 
			Ladder instance = Ladder.Instance;
 
			if ( instance != null ) {
				LadderEntry entry = instance.Find( mobile );
 
				if ( entry != null && ( entry.Wins + entry.Losses ) > 0 ) {
					y += 8;
 
					AddBorderedText( LabelOffset, y, LabelWidth + ValueWidth, 20, "Duelist", WhiteColor32, BlackColor32 );
 
					y += 21;
					AddSeperator( 30, y, Width - 60 );
					y += 3;
 
					string rank = LadderGump.Rank( entry.Index + 1 );
 
					AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Rank:" ), LabelColor32, BlackColor32 );
					AddBorderedText( ValueOffset, y, ValueWidth, 20, rank, WhiteColor32, BlackColor32 );
					y += 20;
 
					AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Level:" ), LabelColor32, BlackColor32 );
					AddBorderedText( ValueOffset, y, ValueWidth, 20, Ladder.GetLevel( entry.Experience ).ToString( "N0" ), WhiteColor32, BlackColor32 );
					y += 20;
 
					AddBorderedText( LabelOffset, y, LabelWidth, 20, Right( "Matches:" ), LabelColor32, BlackColor32 );
					AddBorderedText( ValueOffset, y, ValueWidth, 20, String.Format( "{0:N0}", ( entry.Wins + entry.Losses ) ), WhiteColor32, BlackColor32 );
					y += 20;
				}
			}
 
			Height = y + 12;
 
			Ethic ethic = Ethic.Find( mobile );
 
			if ( ethic == Ethic.Hero ) {
				AddItem( Width - 36, Height - 26, 7188 );
			} else if ( ethic == Ethic.Evil ) {
				AddItem( Width - 35, Height - 36, 6232 );
			}
		}
	}
}
