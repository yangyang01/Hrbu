using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Castle.Windsor;
using Castle.Facilities.WcfIntegration;
using Castle.Windsor.Installer;

namespace Hrbu.Teaching.Core
{
    public class WcfClientContainer : WindsorContainer
    {
        static readonly WcfClientContainer instance = new WcfClientContainer();

        public static WcfClientContainer Instance()
        {
            return instance;
        }

        private WcfClientContainer()
        {
            Install();
        }

        protected void Install()
        {
            this.AddFacility<WcfFacility>()
                .Install(Configuration.FromXmlFile("windsor.xml"));
                                                                                                                                                                                }
    }
}
