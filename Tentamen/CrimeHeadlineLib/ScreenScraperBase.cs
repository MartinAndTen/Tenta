using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    public abstract class ScreenScraperBase
    {
        public abstract string Url { get; }
        public abstract string RegexPattern { get; }

        private string content;
        public string Result;

        public async Task<string> ReadTopCrime()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(Url);
            var v = await response.Content.ReadAsStringAsync();
            content = v;
            return GetCrimeTitle(RegexPattern);
        }

        public string GetCrimeTitle(string pattern)
        {
            string mc = Regex.Match(content, pattern).ToString();
            Result = mc;
            Result = Regex.Replace(Result, @"<[^>]*>", String.Empty);
            return Result;
        }

        //public abstract CrimeHeadlineSystem _mediator;
        //public abstract string Site { get; }
        //public abstract string RegexPattern { get; }

        //public ScreenScraperBase(CrimeHeadlineSystem mediator)
        //{
        //    this._mediator = mediator;
        //    this._mediator.RegisterScr(this);
        //}

        //public async Task<string> ReadTopCrime(string site, string title)
        //{
        //    HttpClient client = new HttpClient();
        //    var response = await client.GetAsync(site);
        //    var content = await response.Content.ReadAsStringAsync();
        //    string mc = Regex.Match(content, RegexPattern).ToString();
        //    mc = Regex.Replace(mc, @"<[^>]*>", String.Empty);
            
        //    this._mediator.FoundCrime("http://www.polisen.se", mc);
        //    return mc;
        //}
    }
}
