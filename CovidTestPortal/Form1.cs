using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidTestObjects;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Cookie = OpenQA.Selenium.Cookie;

namespace CovidTest
{
    public partial class Form1 : Form
    {
        private Cookie userCookie;
        private Cookie portalCookie;
        private Cookie xsrfCookie;
        private IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@".\music.wav"); 
            sp.PlayLooping();
            InitTestLocation();
        }

        private void InitTestLocation()
        {
            cbxLocation.DataSource = JsonConvert.DeserializeObject<List<Location>>(File.ReadAllText(@".\Locations.json"));
            cbxLocation.DisplayMember = "Key";
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDate.DataSource = JsonConvert.DeserializeObject<List<TestDate>>(File.ReadAllText(@".\Dates\"+((Location)cbxLocation.SelectedItem).Value+".json"));
            cbxDate.DisplayMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            string captcha = (string)jse.ExecuteScript("return grecaptcha.execute('6Ld02Z8aAAAAAIvXNdznk-0RFcNMXof3DLTkT8lg', { action: 'submit' }).then(function(grecaptcharesponse) { return(grecaptcharesponse);})");

            CookieContainer cookieContainer = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler(){CookieContainer = cookieContainer};
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://covid-portal.lwz-vorarlberg.at/Portal_CovidTeststation/Covid/FormConfirmed");
            HttpClient client = new HttpClient(handler);
            var values = new Dictionary<string, string>
            {
                { "checkboxGuidelines", "on" },
                { "code", ""},
                { "g-recaptcha-response", captcha},
                {"grecaptcharesponse",captcha},
                {"probeDate", ((TestDate)cbxDate.SelectedItem).Key},
                {"probeLocation", ((Location)cbxLocation.SelectedItem).Value}
            };
            requestMessage.Content = new FormUrlEncodedContent(values);
            //cookieContainer.Add(new System.Net.Cookie(){Name = userCookie.Name, Value = userCookie.Value, Domain = userCookie.Domain, Path = userCookie.Path, HttpOnly = userCookie.IsHttpOnly, Secure = userCookie.Secure});
            //cookieContainer.Add(new System.Net.Cookie() { Name = portalCookie.Name, Value = portalCookie.Value, Domain = portalCookie.Domain, Path = portalCookie.Path, HttpOnly = portalCookie.IsHttpOnly, Secure = portalCookie.Secure });
            requestMessage.Headers.TryAddWithoutValidation("Cookie", "LWZ_UserCookie=" + userCookie.Value+ ";PORTALTOKEN="+portalCookie.Value);
            requestMessage.Headers.TryAddWithoutValidation("X-XSRF-TOKEN", xsrfCookie.Value);

            var response = client.SendAsync(requestMessage);
            var test = response.Result.RequestMessage;
            if (!response.Result.Content.ReadAsStringAsync().Result.Contains("Unauthorized"))
            {
                lblResult.Text = "Erfolgreich";
            }
            else
            {
                lblResult.Text = "Fehlgeschlagen";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new ChromeDriver(service);
            driver.Url = "https://covid-portal.lwz-vorarlberg.at/app-pwa/#!/login";
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 5, 0));
            // get the "Add Item" element
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[text()[contains(., 'Anmeldung zur Testung')]]")));
            driver.FindElement(By.XPath("//*[text()[contains(., 'Anmeldung zur Testung')]]")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("code")));
            userCookie = driver.Manage().Cookies.GetCookieNamed("LWZ_UserCookie");
            portalCookie = driver.Manage().Cookies.GetCookieNamed("PORTALTOKEN");
            xsrfCookie = driver.Manage().Cookies.GetCookieNamed("XSRF-TOKEN");
            button1.Enabled = true;
            driver.Manage().Window.Minimize();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
