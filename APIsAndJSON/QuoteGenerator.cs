using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APIsAndJSON
{
	public class QuoteGenerator
	{
		public static void KanyeQuote()
		{
			// Creates a new instance of HttpClient to send HTTP requests
			var client = new HttpClient();

			// API URL (endpoint)
			var kanyeURL = "https://api.kanye.rest/";

			// GET request. Stores the JSON response in a variable
			var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

			// Parses through the kanyeResponse to get the value associated with the name "quote" (Parse object)
			var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

			// Write Kanye quote to the console
			Console.WriteLine($"-----------------------");
			Console.WriteLine($"Kanye: '{kanyeQuote}'");
			Console.WriteLine($"-----------------------");
		}

		public static void RonQuote()
		{
			var client = new HttpClient();

			var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

			var ronResponse = client.GetStringAsync(ronURL).Result;

			var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

			Console.WriteLine($"-----------------------");
			Console.WriteLine($"Ron: '{ronQuote}'");
			Console.WriteLine($"-----------------------");
		}
	}
}
