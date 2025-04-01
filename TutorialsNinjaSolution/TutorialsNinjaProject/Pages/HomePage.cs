using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V132.Network;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class HomePage
    {
        IWebDriver driver;
        ElementUtilities elementUtilities;

        public HomePage(IWebDriver driver) {

            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);

        }

        private IWebElement MyAccountOption => driver.FindElement(By.XPath("//span[text()='My Account']"));
        private IWebElement LoginOption => driver.FindElement(By.LinkText("Login"));
        private IWebElement SearchBoxField => driver.FindElement(By.Name("search"));
        private IWebElement SearchButton => driver.FindElement(By.CssSelector("button[class='btn btn-default btn-lg']"));

        private IWebElement RegisterOption => driver.FindElement(By.LinkText("Register"));


        public void SelectRegisterOption()
        {
            elementUtilities.ClickOnElement(RegisterOption);
            
        }

        public void ClickOnMyAccountOption()
        {
            elementUtilities.ClickOnElement(MyAccountOption);
            
        }

        public void SelectLoginOption()
        {
            elementUtilities.ClickOnElement(LoginOption);
            
        }

        public void EnterProductIntoSearchBoxField(string searchText)
        {
            elementUtilities.EnterTextIntoElement(SearchBoxField,searchText);    
        }

        public void ClickOnSearchButton()
        {
            elementUtilities.ClickOnElement(SearchButton);
            
        }

    }
}
