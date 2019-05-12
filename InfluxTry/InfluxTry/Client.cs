using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluxData.Net.Common.Enums;
using InfluxData.Net.InfluxDb;
using InfluxData.Net.InfluxDb.Models;
using InfluxData.Net.InfluxDb.Models.Responses;

namespace InfluxTry
{
	class Client
	{
		private InfluxDbClient _client = new InfluxDbClient("http://localhost:8086", "Admin", "Admin", InfluxDbVersion.Latest);

		public void CreateDB(string name)
		{
			_client.Database.CreateDatabaseAsync(name);
			Console.WriteLine($"{name} database is created.");
		}

		public IEnumerable<Database> GetDatabases()
		{
			var result = _client.Database.GetDatabasesAsync().Result;
			return result;
		}

		public async void AddPoint(Point point)
		{

		}
	}
}
