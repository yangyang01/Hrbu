using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.WebUI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teaching.Pages.TeachDocument
{
    public partial class TeachingSyllabus : BasePage
    {
        public ITeachDocument TeachingService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PagerControl.PageChange += new PagerControl.PageRefresh(BindTeachingList);
            if (!IsPostBack)
            {
                checkAuth();
                BindTeachingList();

            }
        }
        public override string PageName
        {
            get
            {
                return "教学大纲";
            }
        }
        protected void BindTeachingList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            //int? SchoolYear = this.ddlYear.SelectedValue.ToNullableInt();
            //int? SchoolSemester = this.ddlSemester.SelectedValue.ToNullableInt();
            //int? Grade = this.ddlGrade.SelectedValue.ToNullableInt();
            //var query = new QueryStringUI()
            //{
            //    SchoolYear = SchoolYear,
            //    SchoolSemester = SchoolSemester,
            //    Grade = Grade
            //};
            var TeachingList = TeachingService.GetTeachingSyllabusByPage(currentPageIndex + 1, PagerControl.PageSize, out totalCount);
            this.rptTeachingList.DataSource = TeachingList;
            this.rptTeachingList.DataBind();
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