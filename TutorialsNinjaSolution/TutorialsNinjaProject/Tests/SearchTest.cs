using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TutorialsNinjaProject.Drivers;
using TutorialsNinjaProject.Pages;

namespace TutorialsNinjaProject.Tests
{
    [TestFixture]   
    internal class SearchTest : BaseTest
    {

        [Test]
        public void VerifySearchingWithExistingProduct()
        {
            HomePage homePage = new HomePage(driver);
            homePage.EnterProductIntoSearchBoxField(config.ExistingProduct.ToString());
            homePage.ClickOnSearchButton();
            SearchPage searchPage = new SearchPage(driver);
            Assert.IsTrue(searchPage.IsProductDisplayedInSearchResults());

        }

        [Test]
        public void VerifySearchingWithANonExistingProduct()
        {
            HomePage homePage = new HomePage(driver);
            homePage.EnterProductIntoSearchBoxField(config.NonExistingProduct.ToString());
            homePage.ClickOnSearchButton();
            SearchPage searchPage = new SearchPage(driver);
            string expectedMessage = "There is no product that matches the search criteria.";
            Assert.AreEqual(expectedMessage, searchPage.GetNoProductMessage());

        }

        [Test]
        public void VerifySearchingWithoutEnteringAnyProduct()
        {

            HomePage homePage = new HomePage(driver);
            homePage.ClickOnSearchButton();
            SearchPage searchPage = new SearchPage(driver);
            string expectedMessage = "There is no product that matches the search criteria.";
            Assert.AreEqual(expectedMessage, searchPage.GetNoProductMessage());

        }

    }
}
