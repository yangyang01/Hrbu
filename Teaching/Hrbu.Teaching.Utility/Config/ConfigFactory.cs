
using Hrbu.Teachings.Utility;
namespace Hrbu.Teaching.Utility
{
    public class ConfigFactory
    {
        public static IConfig CreateConfigInstance()
        {
            return AppConfig.Instance as IConfig;
        }
    }
}
