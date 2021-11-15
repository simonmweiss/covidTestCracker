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
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidTestObjects;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CovidTest
{
    public partial class Form1 : Form
    {
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
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://vorarlbergtestet.lwz-vorarlberg.at/GesundheitRegister/Covid/Register";
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            string captcha = (string)jse.ExecuteScript("return grecaptcha.execute('6LfzL-sZAAAAAA0HC5T8fGz0TzLA7JuNn5GK0Zlz', { action: 'submit' }).then(function(grecaptcharesponse) { return(grecaptcharesponse);})");
            driver.Quit();

            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                { "checkboxSvnr", "false" },
                { "vorname", txtVorname.Text},
                { "nachname", txtNachname.Text},
                {"geburtsdatum",txtGeburtsdatum.Text},
                {"svnr", txtSVNR.Text},
                {"phoneFull", txtTelefonnummer.Text},
                {"email", ""},
                {"checkboxGuidelinesSelf", "true"},
                {"recaptcha", captcha}
            };
            var content = new FormUrlEncodedContent(values);

            var response = client.PostAsync("https://vorarlbergtestet.lwz-vorarlberg.at/GesundheitRegister/Covid/ValidatePersonData", content);
            string res = response.Result.Content.ReadAsStringAsync().Result;
            ValidateResult validateRes = JsonConvert.DeserializeObject<ValidateResult>(res);
            
            
            HttpClient client2 = new HttpClient();
            var values2 = new Dictionary<string, string>
            {
                { "firstName", txtVorname.Text},
                { "lastName", txtNachname.Text},
                {"birthday",txtGeburtsdatum.Text},
                {"svnr", txtSVNR.Text},
                {"geschlecht", ""},
                {"place", txtPLZOrt.Text},
                {"street", txtStrasse.Text},
                {"streetNumber",txtHausnummer.Text},
                {"phone", txtTelefonnummer.Text.Substring(3).Insert(3," ")},
                {"phoneFull", txtTelefonnummer.Text},
                {"email", ""},
                {"code",""},
                {"probeLocation", ((Location)cbxLocation.SelectedItem).Value},
                {"probeDate", ((TestDate)cbxDate.SelectedItem).Key},
                {"checkboxGuidelinesSelf", "on"},
                {"userId", validateRes.Validate},
                {"logonUser",""}
            };
            var content2 = new FormUrlEncodedContent(values2);

            var response2 = client2.PostAsync("https://vorarlbergtestet.lwz-vorarlberg.at/GesundheitRegister/Covid/FormConfirmed", content2);
            if (response2.Result.Content.ReadAsStringAsync().Result != "\"Zugriff verweigert!\"")
            {
                lblResult.Text = "Erfolgreich";
            }
            else
            {
                lblResult.Text = "Fehlgeschlagen";
            }
        }
    }
}
