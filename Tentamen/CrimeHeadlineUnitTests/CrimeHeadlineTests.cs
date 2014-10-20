using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CrimeHeadlineUnitTests
{
    [TestClass]
    public class CrimeHeadlineTests
    {
        [TestMethod]
        public void Test_That_Screen_Scraper_Polisen_Returns_A_Value()
        {
            //Arrange
            string expected = "fyll i rubrik här på senaste nyheten";
            ScreenScraperPolisen scrPolisen = new ScreenScraperPolisen();
            //Act
            Task<string> scrPolisenTask = scrPolisen.ScreenScrapeAsync();
            string actual = scrPolisenTask.Result;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_That_Screen_Scraper_Utryckning_Returns_A_Value()
        {
            //Arrange
            string expected = "fyll i rubrik här på senaste nyheten";
            ScreenScraperUtryckning scrUtryckning = new ScreenScraperUtryckning();
            //Act
            Task<string> scrUtryckning = scrUtryckning.ScreenScrapeAsync();
            string actual = scrUtryckning.Result;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
