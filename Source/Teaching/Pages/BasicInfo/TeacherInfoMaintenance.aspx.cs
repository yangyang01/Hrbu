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

namespace Teaching.Pages.BasicInfo
{
    public partial class TeacherInfoMaintenance : BasePage
    {
        public IBasicInfo TeacherInfo { get; set; }
        public override string PageName
        {
            get
            {
                return "教工信息维护";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            PagerControl.PageChange += new PagerControl.PageRefresh(BindTeacherList);
            if (!IsPostBack)
            {
                if (this.CurrentUser.RoleId == 1)
                {

                    BindTeacherList();
                }
                else
                {
                    BindSelf();
                }
            }
        }
        protected void BindTeacherList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            string UserNo = string.IsNullOrWhiteSpace(this.txtSearchNo.Text) ? null : this.txtSearchNo.Text.Trim();
            string UserName = string.IsNullOrWhiteSpace(this.txtSearchName.Text) ? null : this.txtSearchName.Text.Trim();
            var query = new QueryStringUI()
            {
                UserNo = UserNo,
                UserName = UserName
            };
            var teacherList = TeacherInfo.GetTeacherInfoByPage(query, currentPageIndex, 8, out totalCount);
            this.rptTeacherList.DataSource = teacherList;
            this.rptTeacherList.DataBind();
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
        protected void BindSelf()
        {
            var selfInfo = TeacherInfo.GetTeacherSelfInfoById(this.CurrentUser.UserNo);
            this.rptTeacherList.DataSource = selfInfo;
            this.rptTeacherList.DataBind();
            this.trPage.Visible = false;
        }
        protected void repPend_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                HiddenField hfTeacherInfoID = (HiddenField)e.Item.FindControl("hfTeacherInfoID");
                switch (e.CommandName.ToLower())
                {
                    case "delete":
                        TeacherInfo.DeleteTeacherInfo(hfTeacherInfoID.Value.ToInt());
                        break;
                }
                if (this.CurrentUser.RoleId == 1)
                {
                    BindTeacherList(0);
                }
                else
                {
                    BindSelf();
                }
            }
        }
        protected void SearchQuery(object sender, EventArgs e)
        {
            BindTeacherList(0);
        }
    }
}