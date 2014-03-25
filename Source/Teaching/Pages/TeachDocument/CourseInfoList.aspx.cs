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
using Hrbu.Teaching.Utility;

namespace Teaching.Pages.TeachDocument
{
    public partial class CourseInfoList : BasePage
    {
        public ITeachDocument CourseService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            checkAuth();
            if (!IsPostBack)
            {
                PagerControl.PageChange += new PagerControl.PageRefresh(BindCourseInfoist);
                BindCourseInfoist();
            }
        }
        public override string PageName
        {
            get
            {
                return "课程管理";
            }
        }
        protected void BindCourseInfoist(int currentPageIndex = 0)
        {
            int totalCount = 0;
            int? CourseCode = this.txtSearchNo.Text.ToNullableInt();
            string CourseName = string.IsNullOrWhiteSpace(this.txtSearchName.Text) ? null : this.txtSearchName.Text.Trim();
            var query = new QueryStringUI()
            {
                CourseCode = CourseCode,
                CourseName = CourseName
            };
            var courseList = CourseService.GetCourseInfoByPage(query, currentPageIndex + 1, PagerControl.PageSize, out totalCount);
            this.rptCourseInfoList.DataSource = courseList;
            this.rptCourseInfoList.DataBind();
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
                HiddenField hfCourseID = (HiddenField)e.Item.FindControl("hfCourseID");
                switch (e.CommandName.ToLower())
                {
                    case "delete":
                        CourseService.DeleteCourse(hfCourseID.Value.ToInt());
                        break;
                }
                BindCourseInfoist(0);
            }
        }
        protected void SearchQuery(object sender, EventArgs e)
        {
            BindCourseInfoist(0);
        }
    }
}