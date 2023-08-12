
using TechTalk.SpecFlow;
using SpecflowTask.Drivers;
using OpenQA.Selenium.Chrome;
using Newtonsoft.Json;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace SpecflowTask.Pages.MasterPage.Login
{

    [Binding]
    public class LoginStepDefinitions : CommonDriver
    {

        MarsMasterPage MasterPageObj;
        LoginMethodPassword LoginMethodPassObj;
        LoginMethodUsername LoginMethodUserObj;
        //LoginAssertion LoginAssertObj;
        public LoginStepDefinitions()
        {
            MasterPageObj = new MarsMasterPage();
            LoginMethodPassObj = new LoginMethodPassword();
            LoginMethodUserObj = new LoginMethodUsername();
            //LoginAssertObj = new LoginAssertion();

        }

        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [When(@"I click on Sign In Button")]
        public void WhenIClickOnSignInButton()
        {
            MasterPageObj.MarsMasterPageNavigateToSignInForm();
        }

        [When(@"Type in Valid Credentials")]
        public void WhenTypeInValidCredentials()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\MarsSpecflow\SpecflowTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(0);
            MasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }

        [When(@"Type in Valid Credentials for Case (.*)")]
        public void WhenTypeInValidCredentialsForCase(int p0)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\MarsSpecflow\SpecflowTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(p0);
            MasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(p0), LoginMethodPassObj.userPassword(p0));
        }


        [Then(@"User is logged in Successfully")]
        public void ThenUserIsLoggedInSuccessfully()
        {
            Console.WriteLine(0 + "Pass");
        }

        [When(@"Type in InValid Credentials")]
        public void WhenTypeInInValidCredentials()
        {
            throw new PendingStepException();
        }

        [Then(@"Unsuccessful Login")]
        public void ThenUnsuccessfulLogin()
        {
            throw new PendingStepException();
        }
    }
}

    
