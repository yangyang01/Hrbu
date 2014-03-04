using Hrbu.Teaching.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teaching.Pages.Power
{
    public partial class LimitDetail : System.Web.UI.Page
    {
        public IPower powerInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request["Id"] != null)
            //{
            //    lbRoleName.Text = powerInfo.GetRoleByRoleId(Request["Id"]).NAME;
            //    lbRoleName.Style.Value = "color:Red";
            //}
        }
    }
}