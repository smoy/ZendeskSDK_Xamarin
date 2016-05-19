using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace ZendeskSDK
{
  [Native]
  public enum ZDKAccountState : long
  {
    Unloaded,
    Valid,
    Invalidated
  }

  [Native]
  public enum ZDKAuthenticationType : ulong
  {
    Unknown,
    Jwt,
    Anonymous
  }

  [Native]
  public enum ZDKAPIErrorCode : long
  {
    Unreachable,
    Connection,
    Auth,
    Request,
    Subdomain,
    ClientId,
    UserId,
    DelegateConfig
  }

  [Native]
  public enum ZDKAPILoginState : long
  {
    NotLoggedIn,
    LoggingIn,
    LoggedIn
  }

  [Native]
  public enum ZDKLogLevel : ulong
  {
    Error = 0,
    Warn = 1,
    Info = 2,
    Debug = 3,
    Verbose = 4
  }

  [Native]
  public enum ZDKNetworkStatus : ulong
  {
    NotReachable,
    ReachableViaWiFi,
    ReachableViaWWAN
  }

  [Native]
  public enum ZDKValidation : ulong
  {
    NilError,
    EmptyStringError
  }

  [StructLayout (LayoutKind.Sequential)]
  public struct ZDKLayoutGuide
  {
    public bool layoutTopGuide;

    public bool layoutBottomGuide;
  }

  [Native]
  public enum ZDKNavBarCreateRequestUIType : ulong
  {
    LocalizedLabel,
    Image
  }

  [Native]
  public enum ZDKNavBarConversationsUIType : ulong
  {
    LocalizedLabel,
    Image,
    None
  }

  [Native]
  public enum ZDKRMAAction : long
  {
    RateApp = 1,
    SendFeedback = 2,
    DontAskAgain = 3,
    Undisplayed = 4
  }

  [Native]
  public enum ZDKRMAFeedbackDialogState : long
  {
    Editing = 0,
    Cancel = 1,
    Submitting = 2,
    Success = 3,
    Error = 4
  }

  [Native]
  public enum ZDKSupportViewState : ulong
  {
    ContentLoading,
    ContentLoaded,
    Empty,
    EmptyError
  }

  [Native]
  public enum ZDKToastUIType : ulong
  {
    Info,
    Ok,
    Warning,
    Error,
    count
  }

  [Native]
  public enum ZDKToastUIStyle : ulong
  {
    BackgroundColor,
    BorderColor,
    FontColor,
    ButtonBorderColor,
    ButtonBackgroundColor,
    ButtonFontColor,
    ButtonFontName,
    ButtonFontSize,
    FontName,
    FontSize,
    IconName,
    count
  }

}
