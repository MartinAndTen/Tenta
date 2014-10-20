using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    public class CrimeHeadlineSystem
    {
        private IScreenScraper _scraper;
        internal void RegisterScrPolisen(ScreenScraperPolisen screenScraperPolisen)
        {
            this._scraper = screenScraperPolisen;
        }

        internal void FoundCrime(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        internal void RegisterScr(ScreenScraperBase screenScraperBase)
        {
            throw new NotImplementedException();
        }
    }
}
