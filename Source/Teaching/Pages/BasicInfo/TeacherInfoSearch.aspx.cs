using Hrbu.Teaching.BusinessView.Model;
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
    public partial class TeacherInfoSearch : BasePage
    {
        public IBasicInfo TeacherInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            PagerControl.PageChange += new PagerControl.PageRefresh(BindTeacherList);
            if (!IsPostBack)
            {
                BindTeacherList();
            }
        }
        public override string PageName
        {
            get
            {
                return "教工信息查询";
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
            var teacherList = TeacherInfo.GetTeacherInfoByPage(query,currentPageIndex + 1, PagerControl.PageSize, out totalCount);
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
        protected void SearchQuery(object sender, EventArgs e)
        {
            BindTeacherList(0);
        }
    }
}