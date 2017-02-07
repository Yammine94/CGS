using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ProgrammingFundementalsProject
{
	class Program
	{
		public static int Artistcnt = 0;
		public static int Curatorcnt = 0;
		public static int Artpiececnt = 0;
		public static string Codesearch ="";

		static void Main(string[] args)
		{
			Artist[] MyArtists = new Artist[5];
			Curator[] MyCurators = new Curator[3];
			Artpiece[] MyArtpieces = new Artpiece[10];


			int maxMenuItems = 7;
			int selector = 0;
			bool good = false;
			while (selector != maxMenuItems)
			{
				Console.Clear();
				DrawTitle();
				DrawMenu(maxMenuItems);
				good = int.TryParse(Console.ReadLine(), out selector);
				if (good)
				{
					switch (selector)
					{
						case 1:
							Console.WriteLine("Create and/or enter the Artist's ID:");
							MyArtists[Artistcnt].ID = Console.ReadLine();

							Console.WriteLine("Enter the Artist's first name:");
							MyArtists[Artistcnt].fname = Console.ReadLine();

							Console.WriteLine("Enter the Artist's last name:");
							MyArtists[Artistcnt].lname = Console.ReadLine();

							Artistcnt++;
							Console.WriteLine("The Artist's information has been stored.");

						break;
							
						case 2:
							Console.WriteLine("Please create and/or enter the Curator's ID:");
							MyCurators[Curatorcnt].ID = Console.ReadLine();

							Console.WriteLine("Enter the Curator's first name:");
							MyCurators[Curatorcnt].fname = Console.ReadLine();

							Console.WriteLine("Enter the Curator's last name:");
							MyCurators[Curatorcnt].lname = Console.ReadLine();

							Curatorcnt++;
							Console.WriteLine("The Curator's information has been stored.");

						break;
							
						case 3:
							Console.WriteLine("Enter the Artpiece's ID:");
								MyArtpieces[Artpiececnt].ID = Console.ReadLine();
							Console.WriteLine("Enter the Artpiece's title:");
								MyArtpieces[Artpiececnt].title = Console.ReadLine();
							Console.WriteLine("Enter the Artpiece's date:");
								MyArtpieces[Artpiececnt].date = Console.ReadLine();
							Console.WriteLine("Enter the Artpiece's Artist ID:");
								MyArtpieces[Artpiececnt].IDArtist = Console.ReadLine();
							Console.WriteLine("Enter the Artpiece's Curator ID:");
								MyArtpieces[Artpiececnt].IDCurator = Console.ReadLine();
							Console.WriteLine("Enter the Artpiece's esteem:");
								MyArtpieces[Artpiececnt].esteem = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Enter the Artpiece's price:");
								MyArtpieces[Artpiececnt].price = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Enter the Artpiece's status:");
								MyArtpieces[Artpiececnt].status = Convert.ToChar(Console.ReadLine());

							Artpiececnt++;
							Console.WriteLine("The Artpiece's information has been stored");

						break;
							
						case 4:
							int count = 0;
							foreach (Artpiece art in MyArtpieces)
							{
								DrawStarLine();
								Console.WriteLine(art.ID);
								Console.WriteLine(art.title);
								Console.WriteLine(art.date);
								Console.WriteLine(art.IDArtist);
								Console.WriteLine(art.IDCurator);
								Console.WriteLine(art.esteem);
								Console.WriteLine(art.price);
								Console.WriteLine(art.status);
								count++;
								DrawStarLine();
								if (count == Artpiececnt)
								{
									break;
								}
							}
							Console.ReadLine();
							break;
							
						case 5:
							Console.WriteLine("Enter the Artpiece ID:");
							Codesearch = Console.ReadLine();
							if (Codesearch == null)
							{
								throw new SystemException("No ID input detected.");
							}
							Console.WriteLine("Artpiece ID search reuslt:");
							foreach (Artpiece art in MyArtpieces)
							{
								if (Codesearch == art.ID)
								{
									Console.WriteLine(art.title);
									Console.WriteLine(art.date);
									Console.WriteLine(art.IDArtist);
									Console.WriteLine(art.IDCurator);
									Console.WriteLine(art.esteem);
									Console.WriteLine(art.price);
									Console.WriteLine(art.status);
								}
							}

							Console.ReadLine();
							break;
						case 6:
							Console.WriteLine("Input the exact artpiece ID of the piece you wish to delete from the system.");
							string codeDelete = Console.ReadLine();
							foreach (Artpiece art in MyArtpieces)
							{
								if (codeDelete == art.ID)
								{
									Array.Clear(MyArtpieces,0,1);
									Console.WriteLine("The artpiece's file has been deleted from the system.");
								}
							}

							break;
						case 7:
							
							break;	
						default:
							if (selector != maxMenuItems)
							{
								ErrorMessage();
							}
							break;
					}
				}
				else
				{
					ErrorMessage();
				}
				Console.ReadKey();
			}
		}


		private static void ErrorMessage()
		{
			Console.WriteLine("Typing error, press key to continue.");
		}
		private static void DrawStarLine()
		{
			Console.WriteLine("************************");
		}
		private static void DrawTitle()
		{
			DrawStarLine();
			Console.WriteLine("Computerized Gallery System");
			DrawStarLine();
		}
		private static void DrawMenu(int maxitems)
		{
			DrawStarLine();
			Console.WriteLine(" 1. Add an artist.");
			Console.WriteLine(" 2. Add a curator.");
			Console.WriteLine(" 3. Add an art piece");
			Console.WriteLine(" 4. Display all art pieces");
			Console.WriteLine(" 5. Find an art piece by code");
			Console.WriteLine(" 6. Delete an art piece");
			Console.WriteLine(" 7. Quit the application");
			DrawStarLine();
			Console.WriteLine("Make your choice: type 1, 2, 3, 4, 5, 6 or {0} for exit", maxitems);
			DrawStarLine();
		}
	}
}
