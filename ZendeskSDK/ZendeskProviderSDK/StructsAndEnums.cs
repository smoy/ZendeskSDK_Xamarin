using System;
using ObjCRuntime;

namespace ZendeskProviderSDK
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
}

