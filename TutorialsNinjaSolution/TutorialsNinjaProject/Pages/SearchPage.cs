using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class SearchPage
    {

        IWebDriver driver;
        ElementUtilities elementUtilities;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);
        }

        private IWebElement existingProduct => driver.FindElement(By.LinkText("HP LP3065"));

        private IWebElement noProductMessage => driver.FindElement(By.XPath("//div[@id='content']/p[2]"));

        public bool IsProductDisplayedInSearchResults()
        {
            return elementUtilities.IsElementDisplayed(existingProduct);
        }

        public string GetNoProductMessage()
        {
            return elementUtilities.GetTextFromElement(noProductMessage);
        }



    }
}
