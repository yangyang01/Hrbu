using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.WebUI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                BindTeacherList();
            }
        }
        protected void BindTeacherList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var teacherList = TeacherInfo.GetTeacherInfoByPage(currentPageIndex + 1, 2, out totalCount);
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
    }
}