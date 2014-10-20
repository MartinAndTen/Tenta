using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    class ScreenScraperPolisen : ScreenScraperBase, IScreenScraper
    {
        public override string Url
        {
            get { return "http://www.polisen.se/"; }
        }

        public override string RegexPattern
        {
            //Lyckades inte klura ut hur mitt regex pattern för Polisen.se ska se ut
            get { return "<span [^>]*class=(\"|')news-date(\"|')>(.*?)</span>"; }
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
