using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluxTry
{
	class UserInterface
	{
		private Client _client = new Client();


		public int Run()
		{
			while (true)
			{
				Console.WriteLine(
@"1 - Create DB
2 - Get DBs
3 - Add Point
0 - Exit");
				var choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
					{
						Console.WriteLine("Write DB name");
						var name = Console.ReadLine();
						_client.CreateDB(name);
					}
						break;
					case 2:
					{
						var DBs = _client.GetDatabases();
						foreach (var db in DBs)
						{
							Console.WriteLine(db.Name);
						}
					}
						break;
					case 0:
						return 0;
				}
				Console.WriteLine("Press any key");
				Console.ReadKey();
				Console.Clear();
			}
		}
	}
}
