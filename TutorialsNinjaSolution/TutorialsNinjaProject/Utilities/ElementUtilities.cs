using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TutorialsNinjaProject.Utilities
{
    internal class ElementUtilities
    {

        IWebDriver driver;

        public ElementUtilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetTextFromElement(IWebElement element)
        {
            string text = "";
            if (IsElementDisplayed(element))
            {
                text = element.Text;
            }
            return text;
        }

        public void EnterTextIntoElement(IWebElement element,string text)
        {

            if(IsElementDisplayed(element) && IsElementEnabled(element))
            {
                element.Clear();
                element.SendKeys(text);
            }

        }

        public void ClickOnElement(IWebElement element)
        {
            if(IsElementDisplayed(element) && IsElementEnabled(element))
            {
                element.Click();
            }
        }

        public bool IsElementEnabled(IWebElement element)
        {
            bool b = false;

            if (IsElementDisplayed(element))
            {
                b = element.Enabled;
            }
            return b;
        }

        public bool IsElementDisplayed(IWebElement element)
        {
            bool b = false;

            try
            {
                b = element.Displayed;
            }catch(NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }

            return b;
           
        }


    }
}
