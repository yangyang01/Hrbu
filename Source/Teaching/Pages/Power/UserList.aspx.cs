using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.WebUI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;

namespace Teaching.Pages.Power
{
    public partial class UserList : BasePage
    {
        public IPower powerService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            PagerControl.PageChange += new PagerControl.PageRefresh(BindUserist);
            if (!IsPostBack)
            {
                BindUserist();
            }
        }
        public override string PageName
        {
            get
            {
                return "用户管理";
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
        protected void repPend_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                HiddenField hfUserID = (HiddenField)e.Item.FindControl("hfUserID");
                switch (e.CommandName.ToLower())
                {
                    case "delete":
                        powerService.DeleteUser(hfUserID.Value.ToInt());
                        break;
                }
                BindUserist(0);
            }
        }
    }
}