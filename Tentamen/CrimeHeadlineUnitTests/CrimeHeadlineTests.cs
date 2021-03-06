﻿using System;
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
            IScreenScraper scraperPolisen = ScreenScraperFactory.CreateScraper("Polisen");
            //Act
            Task<string> scrPolisenTask = scraperPolisen.ReadTopCrime();
            string result = scrPolisenTask.Result;
            //Assert
            Console.WriteLine(result);
            if (result == string.Empty)
            {
                result = null;
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_That_Screen_Scraper_Utryckning_Returns_A_Value()
        {
            //Arrange
            CrimeHeadlineSystem mediator = new CrimeHeadlineSystem();
            IScreenScraper scraperUtryckning = ScreenScraperFactory.CreateScraper("Utryckning");
            //Act
            Task<string> scrUtryckningTask = scraperUtryckning.ReadTopCrime();
            string result = scrUtryckningTask.Result;
            //Assert
            Console.WriteLine(result);
            if (result == string.Empty)
            {
                result = null;
            }
            Assert.IsNotNull(result);
        }
    }
}
