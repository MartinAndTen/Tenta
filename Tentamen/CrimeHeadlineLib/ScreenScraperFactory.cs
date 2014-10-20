using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    class ScreenScraperFactory
    {
        public static IScreenScraper CreateScreenScrape(CrimeHeadlineSystem mediator, string type)
        {
            IScreenScraper scraper = null;
            if (type == "Polisen")
            {
                scraper = new ScreenScraperPolisen(mediator);
            }
            else if (type == "Utryckning")
            {
                scraper = new ScreenScraperUtryckning(mediator);
            }
            return scraper;
        }
    }
}
