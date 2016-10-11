using Foundation;
using UIKit;
using ZendeskProviderSDK;

namespace ZendeskSDKExample
{
  // The UIApplicationDelegate for the application. This class is responsible for launching the
  // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
  [Register("AppDelegate")]
  public class AppDelegate : UIApplicationDelegate
  {
    // class-level declarations

    public override UIWindow Window
    {
      get;
      set;
    }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
      // Override point for customization after application launch.
      // If not required for your application you can safely delete this method

      // Try setting the SDK with your valid information
      // https://developer.zendesk.com/embeddables/docs/ios/gettingstarted

      // Below values are from https://github.com/zendesk/sdk_demo_app_ios
      // This is just so you can immediately play with the Xamarin example
      const string SampleApplicationId = "e5dd7520b178e21212f5cc2751a28f4b5a7dc76698dc79bd";
      const string SampleZendskUrl = "https://rememberthedate.zendesk.com";
      const string SampleOAuthToken = "client_for_rtd_jwt_endpoint";

      ZDKConfig.Instance().InitializeWithAppId(SampleApplicationId, SampleZendskUrl, SampleOAuthToken);
      var identity = new ZDKAnonymousIdentity ();
      identity.Name = "John Doe";
      identity.Email = "john@doe.com";
      identity.ExternalId = "johndoe123";
      ZDKConfig.Instance ().UserIdentity = identity;

      return true;
    }

    public override void OnResignActivation(UIApplication application)
    {
      // Invoked when the application is about to move from active to inactive state.
      // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
      // or when the user quits the application and it begins the transition to the background state.
      // Games should use this method to pause the game.
    }

    public override void DidEnterBackground(UIApplication application)
    {
      // Use this method to release shared resources, save user data, invalidate timers and store the application state.
      // If your application supports background exection this method is called instead of WillTerminate when the user quits.
    }

    public override void WillEnterForeground(UIApplication application)
    {
      // Called as part of the transiton from background to active state.
      // Here you can undo many of the changes made on entering the background.
    }

    public override void OnActivated(UIApplication application)
    {
      // Restart any tasks that were paused (or not yet started) while the application was inactive. 
      // If the application was previously in the background, optionally refresh the user interface.
    }

    public override void WillTerminate(UIApplication application)
    {
      // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
    }
  }
}


