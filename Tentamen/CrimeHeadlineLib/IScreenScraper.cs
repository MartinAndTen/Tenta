using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    public interface IScreenScraper
    {
        string Result { get; set; }
        Task<string> ReadTopCrime();
        string GetCrimeTitle(string Title);
    }
}
