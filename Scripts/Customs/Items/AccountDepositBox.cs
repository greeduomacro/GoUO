/*
   _______________________
 =(__    ___      __     _)=
   |                     |
   |                     |
   |    Scripted By;     |
   |        JBob         |
   |                     |
   |     Version 1.1     |
   |   Date: 8/24/2014   |
   |                     |
   |                     |
   |__    ___   __    ___|
 =(_______________________)=
 
Version 1.1 Changes
	-Confirmation Gump
	-Name Properties
	-Added a couple more checks
ToDo
	Check if Account has been Deleted and if so 
	Delete everything inside and reset.
*/
using Server;
using Server.Items;
using Server.Multis;
using Server.Network;
using Server.Mobiles;
using Server.Accounting;
using Server.Gumps;
using Server.Commands;
using System;


namespace Server.Items
{
	[FlipableAttribute( 0xE41, 0xE40 )] 
	public class AccountDepositBox : BaseContainer 
	{
		public override int MaxWeight{ get{ return 1200; } }
		public virtual int MaxItems{ get{ return 250; } }
	#region Account Info
        public string m_Account;	
        [CommandProperty(AccessLevel.GameMaster)]
        public string Account
        {
            get
            {
				return this.m_Account;
			}
            set
            {
				this.m_Account = value;
			}
        }
	#endregion	
		Random random = new Random();
		[Constructable]
        public AccountDepositBox() : this(null){}
        [Constructable]
        public AccountDepositBox(string account) : this(account, 0xE41, 0xE40){}
        public AccountDepositBox(string account, int itemID) : this(account, itemID, itemID){}	
		public AccountDepositBox(string account, int inactiveItemID, int activeItemID) : base(inactiveItemID)
		{
			this.m_Account = account;
			Name = "Account Deposit Box";
			Movable = false;
		} 
		
		public override bool IsDecoContainer
		{
			get{ return false; }
		}
	#region DoubleClick
		public override void OnDoubleClick(Mobile from)
		{
			Mobile player = from as Mobile;
			if (player.InRange( this.GetWorldLocation(), 2 ) == false)
			{
				player.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
				return;
			}
			if ( this.Account == null )
			{
				player.SendGump(new AccountDBox(player));
				if (player.BankBox.ConsumeTotal(typeof( Gold ), 50000) == true)
				{
					this.m_Account = player.Account.Username;
					this.Hue = 0x482;
					this.Name = player.Name.ToString() + "'s Account Deposit Box";
				}
				return;
			}
			else
			{
				if ( this.Account == player.Account.Username || player.AccessLevel >= AccessLevel.Seer )
				{
					if ( player.AccessLevel >= AccessLevel.Seer || player.InRange( this.GetWorldLocation(), 2 ) )
					{
						Open( player );
						return;
					}
					if ( this.RootParent is PlayerVendor )
					{
						if ( this.Name != ( player.Name.ToString() + "'s Account Deposit Box" ) )
						{
							this.Name = player.Name.ToString() + "'s Account Deposit Box";
							Open( player );
							return;
						}
						else
						{
							Open( player );
							return;
						}
					}
					else
					{
						player.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
					}
					return;
				}
				else if ( this.Account != player.Account.Username )
				{
					player.SendMessage( "This is not yours to use.  You should consider buying your own Account Deposit Box." );
					return;
				}
			}
			return;
		}
	#endregion
	#region AddNameProperty
		public override void AddNameProperty(ObjectPropertyList list)
        {
			base.AddNameProperty( list );
			if (m_Account == null)
			{ 
				list.Add( "<BASEFONT COLOR=#669966>" + "[Price: 50,000 Gold]" + "<BASEFONT COLOR=#FFFFFF>" );
      		}
			else if (m_Account != null)
			{
				list.Add( "<BASEFONT COLOR=#669966>" + "[Unavailable]" + "<BASEFONT COLOR=#FFFFFF>" );
			}
        }
	#endregion		
		public AccountDepositBox( Serial serial ) : base( serial ) 
		{ 
		} 
	#region Ser/Des
		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 );
			writer.Write((string)this.m_Account);
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt();
			this.m_Account = reader.ReadString();
		}
	#endregion
	} 
}

namespace Server.Gumps
{
    public class AccountDBox : Gump
    {
        Mobile caller;

        public static void Initialize()
        {
            CommandSystem.Register("AccountDBoxGump", AccessLevel.Administrator, new CommandEventHandler(AccountDBoxGump_OnCommand));
        }

        [Usage("AccountDBoxGump")]
        [Description("Makes a call to your custom gump.")]
        public static void AccountDBoxGump_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;

            if (e.Mobile.HasGump(typeof(AccountDBox)))
                e.Mobile.CloseGump(typeof(AccountDBox));
            e.Mobile.SendGump(new AccountDBox(e.Mobile));
        }

        public AccountDBox(Mobile from) : this()
        {
        }

        public AccountDBox() : base( 0, 0 )
        {
            this.Closable=false;
			this.Disposable=false;
			this.Dragable=false;
			this.Resizable=false;

			AddPage(0);
			AddBackground(213, 137, 215, 168, 9200);
			AddHtml( 221, 145, 198, 90, @"You are about to buy use of this Account Deposit Box for 50,000 Gold.", (bool)true, (bool)false);
			AddLabel(291, 244, 0, @"Continue?");
			AddButton(241, 271, 247, 248, (int)Buttons.Okay, GumpButtonType.Reply, 0);
			AddButton(339, 271, 241, 243, (int)Buttons.Cancel, GumpButtonType.Reply, 0);
			

            
        }
		private enum Buttons
		{
			Okay,
			Cancel
		}

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;
            switch(info.ButtonID)
            {
                case (int)Buttons.Okay:
				{
					
					Item[] Token = sender.Mobile.BankBox.FindItemsByType( typeof( Gold ) );
					if ( sender.Mobile.BankBox.ConsumeTotal( typeof( Gold ), 50000 ) )
					{
						//AccountDepositBox box = new AccountDepositBox(sender.Mobile);//Will Not Compile.
						AccountDepositBox box = new AccountDepositBox();//Compiles but doesn't let m_Account, Hue, and Name be set.
						box.m_Account = sender.Mobile.Account.Username;
						box.Hue = 0x482;
						box.Name = sender.Mobile.Name.ToString() + "'s Account Deposit Box";
						sender.Mobile.SendMessage("You successfully bought use of this Account Deposit Box!");
						sender.Mobile.SendMessage("This Account Deposit Box is now linked to all characters on this account.");
					}
					else
					{
						sender.Mobile.SendMessage( "You do not have enough gold in the bank to purchase the Account Deposit Box." );
						return;
					}
					break;
				}
				case (int)Buttons.Cancel:
				{
					sender.Mobile.SendMessage("You decide against buying use of this Account Deposit Box.");
					sender.Mobile.CloseGump(typeof(AccountDBox));
					break;
				}

            }
        }
    }
}