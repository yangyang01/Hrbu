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
    public partial class StudentInfoSearch : BasePage
    {
        public IBasicInfo studentInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            PagerControl.PageChange += new PagerControl.PageRefresh(BindStudentList);
            if (!IsPostBack)
            {
                BindStudentList();
            }
        }
        public override string PageName
        {
            get
            {
                return "学生信息查询";
            }
        }
        protected void BindStudentList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            string UserNo = string.IsNullOrWhiteSpace(this.txtSearchNo.Text) ? null : this.txtSearchNo.Text.Trim();
            string UserName = string.IsNullOrWhiteSpace(this.txtSearchName.Text) ? null : this.txtSearchName.Text.Trim();
            var query = new QueryStringUI()
            {
                UserNo = UserNo,
                UserName = UserName
            };
            var studentList = studentInfo.GetStudentInfoByPage(query,currentPageIndex + 1, 2, out totalCount);
            this.rptStudentList.DataSource = studentList;
            this.rptStudentList.DataBind();
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
            BindStudentList(0);
        }
    }
}