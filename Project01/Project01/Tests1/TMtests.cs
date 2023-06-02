using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project01.Pages1;

//open Chrome browser

IWebDriver driver = new ChromeDriver();

//Loginpage object intialization and definition

Loginpage loginPageObj = new Loginpage();
loginPageObj.LoginSteps(driver);

//Homepage object intialization and definition

Homepage homePageObj = new Homepage();
homePageObj.GoToTMPage(driver);


//TMpage object intialization and definition

TMpage TMpageObj = new TMpage();
TMpageObj.CreateTM(driver);

//EditTM

//DeleteTM
