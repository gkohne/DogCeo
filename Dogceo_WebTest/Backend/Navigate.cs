﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Dogceo_WebTest.Backend
{
    public  static class Navigate
    {
        const string HomeUrl = "http://www.way2automation.com/angularjs-protractor/webtables/";

        /// <summary>
        /// Used to Navigate to pages
        /// </summary>
        /// <param name="page">page to naviaget to</param>
        public static void NavigateTo(Page page)
        {
            switch (page)
            {
                case Page.HomePage:
                    Driver.Inst.Navigate().GoToUrl(HomeUrl);
                    new WebDriverWait(Driver.Inst, TimeSpan.FromSeconds(30)).Until(
                          d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                    break;
            }
        }

        public enum Page
        {
            HomePage
        }

    }
}