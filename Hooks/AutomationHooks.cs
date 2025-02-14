﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace specflow_automation.Hooks
{
    [Binding]
    internal class AutomationHooks
    {
        public static IWebDriver driver;

        [AfterScenario]
        public void EndScenario()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

    }
}
