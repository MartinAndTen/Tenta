using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using CrimeHeadlineLib;

namespace CrimeHeadlineUnitTests
{
    [TestClass]
    public class CrimeHeadlineTests
    {
        [TestMethod]
        public void Test_That_Screen_Scraper_Polisen_Returns_A_Value()
        {
            //Arrange
            CrimeHeadlineSystem mediator = new CrimeHeadlineSystem();
            ScreenScraperPolisen scrPolisen = new ScreenScraperPolisen(mediator);
            //Act
            Task<string> scrPolisenTask = scrPolisen.ScreenScrapeAsync();
            string actual = scrPolisenTask.Result;
            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void Test_That_Screen_Scraper_Utryckning_Returns_A_Value()
        {
            //Arrange
            CrimeHeadlineSystem mediator = new CrimeHeadlineSystem();
            ScreenScraperUtryckning scrUtryckning = new ScreenScraperUtryckning(mediator);
            //Act
            Task<string> scrUtryckningTask = scrUtryckning.ScreenScrapeAsync();
            string actual = scrUtryckningTask.Result;
            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.IsNotNull(actual);
        }
    }
}
