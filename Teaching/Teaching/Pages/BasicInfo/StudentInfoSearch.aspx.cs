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
            PagerControl.PageChange += new PagerControl.PageRefresh(BindStudentList);
            if (!IsPostBack)
            {
                BindStudentList();
            }
        }
        protected void BindStudentList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var studentList = studentInfo.GetStudentInfoByPage(currentPageIndex + 1, 2, out totalCount);
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
    }
}