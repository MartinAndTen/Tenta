using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    class ScreenScraperUtryckning : ScreenScraperBase, IScreenScraper
    {
        public override string Url
        {
            get { return "http://www.utryckning.se/"; }
        }

        public override string RegexPattern
        {
            get { return "<h1[^>]*?>(?<TagText>.*?)</h1>"; }
        }

        string IScreenScraper.Result
        {
            get
            {
                return Result;
            }
            set
            {
                Result = value;
            }
        }
    }
}