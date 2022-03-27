using SpecFlowTestProject.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Quit();
        }
    }
}
