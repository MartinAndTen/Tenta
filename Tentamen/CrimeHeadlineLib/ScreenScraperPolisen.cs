using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineLib
{
    class ScreenScraperPolisen
    {
        private CrimeHeadlineSystem _mediator;

        public ScreenScraperPolisen(CrimeHeadlineSystem mediator)
        {
            this._mediator = mediator;
            this._mediator.RegisterScrPolisen(this);
        }
    }
}
