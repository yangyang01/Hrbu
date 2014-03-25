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
using Hrbu.Teaching.BusinessView.Model;

namespace Teaching.Pages.Power
{
    public partial class UserList : BasePage
    {
        public IPower powerService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            if (!IsPostBack)
            {
                PagerControl.PageChange += new PagerControl.PageRefresh(BindUserist);
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
            string UserNo = string.IsNullOrWhiteSpace(this.txtSearchNo.Text) ? null : this.txtSearchNo.Text.Trim();
            string UserName = string.IsNullOrWhiteSpace(this.txtSearchName.Text) ? null : this.txtSearchName.Text.Trim();
            var query = new QueryStringUI()
            {
                UserNo = UserNo,
                UserName = UserName
            };
            var UserList = powerService.GetUserInfoByPage(query, currentPageIndex + 1, PagerControl.PageSize, out totalCount);
            this.rptUserList.DataSource = UserList;
            this.rptUserList.DataBind();
            if (totalCount == 0)
            {
                this.phNoData.Visible = true;
                this.trPage.Visible = false;
            }
            else
            {
                this.phNoData.Visible = false;
                this.trPage.Visible = true;
            }
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
        protected void SearchQuery(object sender, EventArgs e)
        {
            BindUserist(0);
        }
    }
}