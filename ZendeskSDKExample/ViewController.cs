using System;

using UIKit;
using ZendeskProviderSDK;
using ZendeskSDK;

namespace ZendeskSDKExample
{
  public partial class ViewController : UINavigationController
  {
    public ViewController(IntPtr handle)
      : base(handle)
    {
    }

    public override void ViewDidLoad()
    {
      base.ViewDidLoad();
      // Perform any additional setup after loading the view, typically from a nib.

      ZDKHelpCenter.PushHelpCenterWithNavigationController(this);
    }

    public override void DidReceiveMemoryWarning()
    {
      base.DidReceiveMemoryWarning();
      // Release any cached data, images, etc that aren't in use.
    }
  }
}

