#region Header
//   Vorspire    _,-'/-'/  Admin.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2014  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;
using System.Collections.Generic;
using System.Linq;

using Server.Gumps;
using Server.Items;
using Server.Mobiles;

using VitaNex.SuperGumps.UI;
#endregion

namespace VitaNex.Modules.EquipmentSets
{
	public sealed class EquipmentSetsAdminUI : ListGump<EquipmentSet>
	{
		public static string HelpText =
			"Sets: List specific Item Types and Mods as an Equipment Set.\nWhenever the equipped parts total meets a Mods' requirement, the Mod will activate.\nWhenever the equipped parts total falls below a Mods' requirement, the Mod will deactivate.";

		public EquipmentSetsAdminUI(PlayerMobile user, Gump parent = null)
			: base(user, parent, emptyText: "There are no equipment sets to display.", title: "Equipment Sets Control Panel")
		{
			ForceRecompile = true;
		}

		protected override void CompileList(List<EquipmentSet> list)
		{
			list.Clear();
			list.AddRange(EquipmentSets.Sets.Values);
			base.CompileList(list);
		}

		public override string GetSearchKeyFor(EquipmentSet key)
		{
			return key != null ? key.Name : base.GetSearchKeyFor(null);
		}

		protected override void CompileMenuOptions(MenuGumpOptions list)
		{
			if (User.AccessLevel >= EquipmentSets.Access)
			{
				list.AppendEntry(new ListGumpEntry("Module Settings", OpenConfig, HighlightHue));
			}

			list.AppendEntry(new ListGumpEntry("Help", ShowHelp));
			base.CompileMenuOptions(list);
		}

		protected override void SelectEntry(GumpButton button, EquipmentSet entry)
		{
			base.SelectEntry(button, entry);

			MenuGumpOptions opts = new MenuGumpOptions();

			if (User.AccessLevel >= EquipmentSets.Access)
			{
				opts.AppendEntry(
					new ListGumpEntry(
						"Create Bag Of Parts",
						b =>
						{
							if (entry.Count == 0)
							{
								User.SendMessage("This equipment set contains no parts.");
								Refresh();
								return;
							}

							Bag bag = new Bag
							{
								Name = String.Format("a bag of {0} parts", entry.Name)
							};

							entry.Select(part => part.CreateInstanceOfPart()).Not(item => item == null || item.Deleted).ForEach(bag.DropItem);

							if (!User.PlaceInBackpack(bag))
							{
								bag.Delete();
							}
						},
						HighlightHue));
			}

			Send(new MenuGump(User, Refresh(), opts, button));
		}

		private void OpenConfig(GumpButton btn)
		{
			Minimize();

			PropertiesGump p = new PropertiesGump(User, EquipmentSets.CMOptions)
			{
				X = X + btn.X,
				Y = Y + btn.Y
			};

			User.SendGump(p);
		}

		private void ShowHelp(GumpButton button)
		{
			if (User != null && !User.Deleted)
			{
				Send(new NoticeDialogGump(User, Refresh(), title: "Help", html: HelpText));
			}
		}
	}
}