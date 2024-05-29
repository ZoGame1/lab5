using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserAccountlab5
{
	public string name;
	public int rank;
	public float winRate;
	public string type;
	public int skin;

	public UserAccountlab5(string name, int rank, float WinRate, string Type, int skin)
	{
		this.name = name;
		this.rank = rank;
		this.winRate = WinRate;
		this.type = Type;
		this.skin = skin;
	}

}
class Promgram
{
	static void Main()
	{

		List<UserAccountlab5> List = new List<UserAccountlab5>();
		List.Add(new UserAccountlab5("Son Tung         ", 10, 88.8f, "ca nhac", 50));
		List.Add(new UserAccountlab5("Den Vau          ", 21, 70, "ca nhac", 10));
		List.Add(new UserAccountlab5("Thuy linh        ", 15, 45.5f, "ca nhac", 25));
		List.Add(new UserAccountlab5("Do Mixi          ", 1, 90, "ALL ", 2));
		List.Add(new UserAccountlab5("Ba Tuyen Diamond ", 3, 60.5f, "Am Thuc", 10));
		List.Add(new UserAccountlab5("PewPew           ", 4, 55.5f, "Live", 50));
		List.Add(new UserAccountlab5("Lien Minnh       ", 2, 35.5f, "Game", 255));
		List.Add(new UserAccountlab5("Lien Quan        ", 11, 55.5f, "Game", 200));
		List.Add(new UserAccountlab5("FIFA 4           ", 7, 12.2f, "Game", 10));
		List.Add(new UserAccountlab5("CSO              ", 5, 81.8f, "Game", 23));
		List.Add(new UserAccountlab5("CSGO             ", 6, 86.5f, "Game", 90));
		Console.WriteLine("-----------------");

			/*in danh sach user*/
		foreach (var player in List)
		{
			Console.WriteLine($"{player.name},|Rank:{player.rank},|Skin:{player.skin}");
		}
		Console.WriteLine("------------------");
		/*sap xep theo rank giam dan */
		var sorted1 = List.OrderBy(x => x.winRate);
		foreach(var player in sorted1)
		{
			Console.WriteLine($"{player.name},|Rank:{player.rank},|Skin:{player.skin}");
		}
		Console.WriteLine("-------------------");
		/*sap xep thep User va Skin*/
		var sorted2 = List.OrderBy(x => x.name).ThenBy(x => x.skin);
		foreach (var player in sorted2)
		{
			Console.WriteLine($"{player.name},|Rank:{player.rank},|Skin:{player.skin}");
		}
		Console.WriteLine("-------Start With B-----------");
		/*Loc nguoi choi*/
		var filteredNames = List.Where(list => list.name.StartsWith("B"));
		foreach (var player in filteredNames)
		{
			Console.WriteLine($"{player.name},|Rank:{player.rank},|Skin:{player.skin}");
		}
		/*Bai 2A*/
		var WinRate50 = List.Where(list => list.winRate>50);
		foreach (var player in WinRate50)
		{
			Console.WriteLine($"{player.name},|Rank:{player.rank},|WinRate:{player.winRate},|Skin:{player.skin}");
		}
		/*Bai 2B*/
		var WinRateMax = List.OrderByDescending(list => list.winRate).FirstOrDefault();
		Console.WriteLine("\n nguoi co WinRate cao nhat la:");
		if ( WinRateMax != null )
		{
			Console.WriteLine($"{WinRateMax.name},|Rank:{WinRateMax.rank},|WinRate:{WinRateMax.winRate},|Skin:{WinRateMax.skin}");
		}
		/*BAi2C*/
		Console.WriteLine("\n So Tai khoan Trong danh sach la: "   + List.Count);
		/*Bai3*/
		var VuiVui = List.ToLookup(list => list.type);
		Console.WriteLine("\n Danh Sach Type la:");
		foreach( var BunBun in VuiVui)
		{
			Console.WriteLine("\ntype: " + BunBun.Key,BunBun.Count());
			foreach( var player in BunBun)
			{
				Console.WriteLine($"{player.name},|Rank:{player.rank},|WinRate:{player.winRate}|Type{player.type},|Skin:{player.skin}");
			}
		}

	}
}
