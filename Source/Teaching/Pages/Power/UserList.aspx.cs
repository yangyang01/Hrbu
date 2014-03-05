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
    public partial class UserList : BasePage
    {
        public IPower powerService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PagerControl.PageChange += new PagerControl.PageRefresh(BindUserist);
            if (!IsPostBack)
            {
                BindUserist();
            }
        }
        protected void BindUserist(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var UserList = powerService.GetUserInfoByPage(currentPageIndex + 1, 2, out totalCount);
            this.rptUserList.DataSource = UserList;
            this.rptUserList.DataBind();
            PagerControl.CurrentPageIndex = currentPageIndex;
            PagerControl.IntialProperties(totalCount);
        }
    }
}