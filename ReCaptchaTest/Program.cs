using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ReCaptchaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver  = new ChromeDriver();
            driver.Url = "https://vorarlbergtestet.lwz-vorarlberg.at/GesundheitRegister/Covid/Register";
            IJavaScriptExecutor jse = (IJavaScriptExecutor) driver;
            string test = (string)jse.ExecuteScript("return grecaptcha.execute('6LfzL-sZAAAAAA0HC5T8fGz0TzLA7JuNn5GK0Zlz', { action: 'submit' }).then(function(grecaptcharesponse) { return(grecaptcharesponse);})");
            driver.Close();
            Console.WriteLine(test);
        }
    }
}
