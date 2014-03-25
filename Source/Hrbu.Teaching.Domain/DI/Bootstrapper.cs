using System.Web.Mvc;
using StructureMap;
using System.Linq;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.Business;

namespace Hrbu.Teaching.Domain
{
    public static class Bootstrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.For<ILogin>().Use<LoginService>();

                x.SetAllProperties(y =>
                {
                    y.OfType<ILogin>();
                });
            });
            ObjectFactory.Initialize(x =>
            {
                x.For<IPower>().Use<PowerService>();

                x.SetAllProperties(y =>
                {
                    y.OfType<IPower>();
                });
            });
            ObjectFactory.Initialize(x =>
            {
                x.For<IBasicInfo>().Use<BasicInfoService>();

                x.SetAllProperties(y =>
                {
                    y.OfType<IBasicInfo>();
                });
            });
            ObjectFactory.Initialize(x =>
            {
                x.For<ITeachDocument>().Use<TeachDocumentService>();

                x.SetAllProperties(y =>
                {
                    y.OfType<ITeachDocument>();
                });
            });
            //ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
            //DependencyResolver.SetResolver(
            //    t =>
            //    {
            //        try { return ObjectFactory.GetInstance(t); }
            //        catch { return null; }
            //    },
            //    t => ObjectFactory.GetAllInstances<object>().Where(s => s.GetType() == t)
            //);

            ObjectFactory.Configure(x =>
            {
                x.AddRegistry(new ControllerRegistry());
            });
        }
    }
}
