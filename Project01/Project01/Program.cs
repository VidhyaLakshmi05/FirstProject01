using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open Chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(3000);


//identify username textbox and enter valid username
IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
UsernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
PasswordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User has not logged in");
}


// create new time record


// navigate to time and material module
IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administration.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

// click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

// select time option from dropdown

IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
dropdown.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();


// type code into code textbox

IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("March2023");

// type description into description textbox

IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
DescriptionTextbox.SendKeys("March2023");


// type price into price per unit textbox
IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceOverlap.Click();

IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("12");

// click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

// check if new time rcord has been created successfully

IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "March2023")
{ 
    Console.WriteLine("New record has been created successfully");
}
else
{
    Console.WriteLine("New record hasn't been created successfully");
}
//