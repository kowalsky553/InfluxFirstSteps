using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluxData.Net.Common.Enums;
using InfluxData.Net.InfluxDb;

namespace InfluxTry
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new UserInterface();
			client.Run();
		}
	}
}
