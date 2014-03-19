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

namespace Teaching.Pages.BasicInfo
{
    public partial class StudentInfoMaintenance : BasePage
    {
        public IBasicInfo studentInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            PagerControl.PageChange += new PagerControl.PageRefresh(BindStudentInfoList);
            if (!IsPostBack)
            {
                if (this.CurrentUser.RoleId == 1)
                {
                    BindStudentInfoList();
                    this.btnAddInfo.Visible = true;
                    this.btnAddInfoList.Visible = true;
                }
                else
                {
                    BindSelf();
                }
            }

        }
        public override string PageName
        {
            get
            {
                return "学生信息维护";
            }
        }
        protected void BindStudentInfoList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var studentInfoList = studentInfo.GetStudentInfoByPage(currentPageIndex + 1, 2, out totalCount);
            this.rptStudentInfoList.DataSource = studentInfoList;
            this.rptStudentInfoList.DataBind();

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
            var selfInfo = studentInfo.GetStudentSelfInfoById(this.CurrentUser.UserNo);
            this.rptStudentInfoList.DataSource = selfInfo;
            this.rptStudentInfoList.DataBind();
            this.trPage.Visible = false;
        }
        protected void repPend_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                HiddenField hfStudentInfoID = (HiddenField)e.Item.FindControl("hfStudentInfoID");
                switch (e.CommandName.ToLower())
                {
                    case "delete":
                        studentInfo.DeleteStudentInfo(hfStudentInfoID.Value.ToInt());
                        break;
                }
                if (this.CurrentUser.RoleId == 1)
                {
                    BindStudentInfoList(0);
                }
                else
                {
                    BindSelf();
                }
            }
        }
    }
}