namespace TailwindTraders.Mobile.Features.Settings
{
    public static class DefaultSettings
    {
        public const string ApiAuthorizationHeader = "Authorization";

        public static string AccessToken = string.Empty;

        public const string AppCenterAndroidSecret = "2bf9b26e-27b1-4a0f-a8f8-e531cdddd361";

        public const string AppCenteriOSSecret = "8c5e3a4e-bbeb-4afe-b277-5cb45704483d";

        public const bool UseFakeAPIs = UITestMode || DebugMode;

        public const bool UseFakeAuthentication = UITestMode || DebugMode;

        public const bool ForceAutomaticLogin = !UITestMode && DebugMode;

        public const bool BreakNetworkRandomly = !UITestMode && DebugMode;

        public const bool AndroidDebuggable = DebugMode;

        public const bool UseDebugLogging = UITestMode || DebugMode;

        public const bool EnableARDiagnostics = DebugMode;

        public const bool DebugMode =
#if DEBUG 
            true;
#else
            false;
#endif

        public const bool UITestMode =
#if IS_UI_TEST
            true;
#else
            false;
#endif

        public static string RootApiUrl { get; set; } = "https://mobileapi.com/";

        public static string RootWebApiUrl
        { get; set; } = "https://webapi.com/";
    }
}
