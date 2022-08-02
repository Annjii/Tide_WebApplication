using System;
using TechTalk.SpecFlow;
using TideSpecFlow.PageOMethod;

namespace TideSpecFlow.step
{
    [Binding]
    public class TideWebApplicationFeatureStepDefinitions
    {
        [Given(@"Load the WebApplication for ContactUs")]
        public void GivenLoadTheWebApplicationForContactUs()
        {
            ContactUs.NavigateURL();
        }

        [When(@"WebApplication load click on the contactUs")]
        public void WhenWebApplicationLoadClickOnTheContactUs()
        {
            ContactUs.ClickOnButton();
        }

        [Then(@"ContactUs get displayed take screenshot")]
        public void ThenContactUsGetDisplayedTakeScreenshot()
        {
            ContactUs.TakeSshottest();
        }

        [Given(@"Load the WebApplication for How To wash Clothes")]
        public void GivenLoadTheWebApplicationForHowToWashClothes()
        {
            HowtoWashClothes.NavigateURL();
        }

        [When(@"WebApplication Load Click on How To wash clothes")]
        public void WhenWebApplicationLoadClickOnHowToWashClothes()
        {
            HowtoWashClothes.ClickOnButton();
        }

        [When(@"How to wash clothes get displayed take screenshot")]
        public void WhenHowToWashClothesGetDisplayedTakeScreenshot()
        {
            HowtoWashClothes.TakeSshottest();
        }

        [Given(@"Load the WebApplication for Register")]
        public void GivenLoadTheWebApplicationForRegister()
        {
            Register.NavigateURL();
        }

        [When(@"WebApplication load click on Register")]
        public void WhenWebApplicationLoadClickOnRegister()
        {
            Register.ClickOnButton();
        }

        [Then(@"Click on Sign Up Now")]
        public void ThenClickOnSignUpNow()
        {
            Register.ClickontheSignup();
        }

        [Then(@"Signin displayed take screenshot")]
        public void ThenSigninDisplayedTakeScreenshot()
        {
            Login.TakeSshottest();
        }

        [Given(@"Load the webApplication for login page")]
        public void GivenLoadTheWebApplicationForLoginPage()
        {
            Login.NavigateURL();
        }

        [When(@"WebApplication load click on the Login")]
        public void WhenWebApplicationLoadClickOnTheLogin()
        {
            Login.EnterEmail();
        }

        [Then(@"write user details")]
        public void ThenWriteUserDetails()
        {
           
            Login.EnterPassword();
        }

        [Then(@"click on login button")]
        public void ThenClickOnLoginButton()
        {
            Login.Loginn();
        }

        [Then(@"Login successfully take the screenshot")]
        public void ThenLoginSuccessfullyTakeTheScreenshot()
        {
            Login.TakeSshottest();
        }

        [Given(@"Load the WebApplication for LiveChat")]
        public void GivenLoadTheWebApplicationForLiveChat()
        {
            Selectloction.NavigateURL();
        }

        [When(@"WebApplication load click on live chat")]
        public void WhenWebApplicationLoadClickOnLiveChat()
        {
            LiveChat.ClickOnLiveChat();
        }

        [Then(@"scroll to live chat")]
        public void ThenScrollToLiveChat()
        {
            LiveChat.ScrollToLiveChat();
        }

        [Then(@"Live Chat displayed take Screenshot")]
        public void ThenLiveChatDisplayedTakeScreenshot()
        {
            LiveChat.TakeSshottest();
        }

        [Given(@"Load the WebApplication for Select a loction")]
        public void GivenLoadTheWebApplicationForSelectALoction()
        {
            Selectloction.NavigateURL();
        }

        [When(@"WebApplication Load Click on Langauge")]
        public void WhenWebApplicationLoadClickOnLangauge()
        {
            Selectloction.ClickOnbutton();
        }

        [Then(@"popup should open and choose Langauge")]
        public void ThenPopupShouldOpenAndChooseLangauge()
        {
            Selectloction.SelectLanguage();
        }

        [Then(@"Language get changed take screenshot")]
        public void ThenLanguageGetChangedTakeScreenshot()
        {
            Selectloction.TakeSshottest();
        }

        [Given(@"Load the WebApplication for Search Bar")]
        public void GivenLoadTheWebApplicationForSearchBar()
        {
            SearchBar.NavigateURL();
        }

        [When(@"WebApplication load click on Search Bar")]
        public void WhenWebApplicationLoadClickOnSearchBar()
        {
            SearchBar.ClickOnSearchBar();
        }

        [Then(@"enter product name in search Bar")]
        public void ThenEnterProductNameInSearchBar()
        {
            SearchBar.EnterDataInSearchBar();
        }

        [Then(@"Result screen displayed take screenshot")]
        public void ThenResultScreenDisplayedTakeScreenshot()
        {
            SearchBar.TakeSshottest();
        }

        [Given(@"Load the WebApplication for ShopProducts")]
        public void GivenLoadTheWebApplicationForShopProducts()
        {
            ShopProducts.NavigateURL();
        }

        [When(@"WebApplication load click on shop products")]
        public void WhenWebApplicationLoadClickOnShopProducts()
        {
            ShopProducts.ClickOnButton();
        }

        [Then(@"Select available product")]
        public void ThenSelectAvailableProduct()
        {
            ShopProducts.SelectProducts();
        }

        [Then(@"click on find retailers")]
        public void ThenClickOnFindRetailers()
        {
            ShopProducts.ClickOnFindRetailers();
        }

        [Then(@"Retailers screen take screenshot")]
        public void ThenRetailersScreenTakeScreenshot()
        {
            ShopProducts.TakeSshottest();
        }

        [Given(@"Load the WebApplication for OurCommitment")]
        public void GivenLoadTheWebApplicationForOurCommitment()
        {
            OurCommitment.NavigateURL();
        }

        [When(@"WebApplication load click on Our Commitment")]
        public void WhenWebApplicationLoadClickOnOurCommitment()
        {
            OurCommitment.ClickOnButton();
        }

        [Then(@"Scroll to Our Ambition option")]
        public void ThenScrollToOurAmbitionOption()
        {
            OurCommitment.ScrollToElement();
        }

        [Then(@"our ambition displayed take screenshot")]
        public void ThenOurAmbitionDisplayedTakeScreenshot()
        {
            OurCommitment.TakeSshottest();
        }

        [Given(@"Load the WebApplication for WhatsNew")]
        public void GivenLoadTheWebApplicationForWhatsNew()
        {
            What_sNew.NavigateURL();
        }

        [When(@"WebApplication load click on the whats new")]
        public void WhenWebApplicationLoadClickOnTheWhatsNew()
        {
            What_sNew.ClickOnWhat_sNewButton();
        }

        [When(@"latest articles screen take screenshot")]
        public void WhenLatestArticlesScreenTakeScreenshot()
        {
            What_sNew.TakeSshottest();
        }
    }
}
