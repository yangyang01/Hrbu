using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teaching.Pages.Power
{
    public partial class UserAddUp : BasePage
    {
        public IPower powerService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}