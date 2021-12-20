using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;



namespace DövizUygulaması


    
    { 
    public partial class Form1 : Form
        
    {
            
            public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
           
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            guncellemebasarili.Visible = false;
            veriguncelleme.Visible = true;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            var driver = new ChromeDriver(driverService,  chromeOptions);
            driver.Navigate().GoToUrl("https://bigpara.hurriyet.com.tr/doviz/dolar/");
            IWebElement dolar = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/div[2]/div[2]/span[2]"));
            textBox1.Text = dolar.Text;
            driver.Close();
            veriguncelleme.Visible = false;
            guncellemebasarili.Visible = true;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
