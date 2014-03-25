using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.WebUI.Code;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI.UserControls;
using Hrbu.Teaching.BusinessView.Model;

namespace Teaching.Pages.TeachDocument
{
    public partial class TrainingProgram : BasePage
    {
        public ITeachDocument TrainService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkAuth();
                PagerControl.PageChange += new PagerControl.PageRefresh(BindTrainCourseList);
                PagerControl1.PageChange += new PagerControl.PageRefresh(BindTrainAimList);
                BindTrainAimList();
                BindTrainCourseList();
                this.ddlGrade.BindDropDownListWithDefault(4);
                this.ddlYear.BindDropDownListWithDefault(5);
                this.ddlSemester.BindDropDownListWithDefault(10);
            }
        }
        public override string PageName
        {
            get
            {
                return "培养方案";
            }
        }
        protected void BindTrainAimList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            int? SchoolYear = this.ddlYear.SelectedValue.ToNullableInt();
            int? SchoolSemester = this.ddlSemester.SelectedValue.ToNullableInt();
            int? Grade = this.ddlGrade.SelectedValue.ToNullableInt();
            var query = new QueryStringUI()
            {
                SchoolYear = SchoolYear,
                SchoolSemester = SchoolSemester,
                Grade = Grade
            };
            var TrainAimList = TrainService.GetTrainAimByPage(query, currentPageIndex + 1, 2, out totalCount);
            this.rptTrainAim.DataSource = TrainAimList;
            this.rptTrainAim.DataBind();
            PagerControl.CurrentPageIndex = currentPageIndex;
            PagerControl.IntialProperties(totalCount);
        }
        protected void BindTrainCourseList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            int? SchoolYear = this.ddlYear.SelectedValue.ToNullableInt();
            int? SchoolSemester = this.ddlSemester.SelectedValue.ToNullableInt();
            int? Grade = this.ddlGrade.SelectedValue.ToNullableInt();
            var query = new QueryStringUI()
            {
                SchoolYear = SchoolYear,
                SchoolSemester = SchoolSemester,
                Grade = Grade
            };
            var TrainCourseList = TrainService.GetTrainCourseByPage(query, currentPageIndex + 1, 2, out totalCount);
            this.rptTrainCourse.DataSource = TrainCourseList;
            this.rptTrainCourse.DataBind();
            PagerControl.CurrentPageIndex = currentPageIndex;
            PagerControl.IntialProperties(totalCount);
        }
    }
}