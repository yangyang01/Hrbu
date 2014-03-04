
namespace Hrbu.Teaching.Utility
{
    public class RuntimeHelper
    {
        public static bool IsInDebugMode()
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }

        public static bool IsInReleaseMode()
        {
#if RELEASE
            return true;
#else
            return false;
#endif
        }

        public static bool IsInLiveMode()
        {
#if LIVE
            return true;
#else
            return false;
#endif
        }
    }
}
