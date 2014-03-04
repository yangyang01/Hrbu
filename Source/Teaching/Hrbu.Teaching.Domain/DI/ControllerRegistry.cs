using Hrbu.Teaching.Business;
using Hrbu.Teaching.Interface;
using StructureMap.Configuration.DSL;


namespace Hrbu.Teaching.Domain
{
    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            For<ILogin>().Use<LoginService>();
            For<IPower>().Use<PowerService>();
            For<IBasicInfo>().Use<BasicInfoService>();
            //RegisterInDifferentMode();
        }


        private void RegisterInDifferentMode()
        {
            var mode = RegistryModeFactory.GetCurrentMode();
            if (mode == RegistryMode.None) mode = RegistryMode.Release;

            if ((mode & RegistryMode.Debug) == RegistryMode.Debug) { RegisterInDebugMode(); }

            if ((mode & RegistryMode.Release) == RegistryMode.Release || (mode & RegistryMode.Live) == RegistryMode.Live) { RegisterInReleaseMode(); }
        }

        #region Debug

        private void RegisterInDebugMode()
        {
            //For<IUserService>().Use<FakeUserService>();
        }

        #endregion

        #region Release
        private void RegisterInReleaseMode()
        {
            //For<IUserService>().Use<UserService>();
        }
        #endregion

    }
}
