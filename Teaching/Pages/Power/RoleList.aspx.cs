using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.WebUI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teaching.Pages.Power
{
    public partial class RoleList : BasePage
    {
        public IPower powerInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PagerControl.PageChange += new PagerControl.PageRefresh(BindRoleList);
            if (!IsPostBack)
            {
                BindRoleList();
            }
        }
        protected void BindRoleList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var RoleList = powerInfo.GetRoleInfoByPage(currentPageIndex + 1, 2, out totalCount);
            this.rptRoleList.DataSource = RoleList                                 ;
            this.rptRoleList.DataBind();
            PagerControl.CurrentPageIndex = currentPageIndex;
            PagerControl.IntialProperties(totalCount);
        }
    }
}