using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    public class ScreenScraperFactory
    {
        public static IScreenScraper CreateScraper(string type)
        {
            IScreenScraper scraper = null;
            if (type == "Polisen")
            {
                scraper = new ScreenScraperPolisen();
            }
            else if (type == "Utryckning")
            {
                scraper = new ScreenScraperUtryckning();
            }
            return scraper;
        }
    }
}
