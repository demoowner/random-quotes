using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RandomQuotes.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        // Let's create a quick and dirty set of strings for our quotes.
        private static readonly string[] Quotes =
        {
            "If you can't explain it simply, you don't understand it well enough. -Albert Einstein",
            "Innovation distinguishes between a leader and a follower. -Steve Jobs",
            "Success is a lousy teacher. It seduces smart people into thinking they can't lose. -Bill Gates"
        };

        // GET api/quotes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Quotes;
        }

        // GET api/quotes/random
        [HttpGet("quotes/random")]
        public string GetRandom()
        {
            // Generate a random number between 0 and the length of the array
            Random rand = new System.Random();
            int randIndex = rand.Next(0, Quotes.Length);

            return Quotes[randIndex];
        }
    }
}
