using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;

namespace Teaching.Pages.TeachDocument
{
    public partial class SyllabusDetailAdd : BasePage
    {
        public ITeachDocument TeachingService { get; set; }

        public int BasicCode
        {
            get
            {
                return GetQueryValue("BasicCode").ToInt();
            }
        }
        public string CourseName
        {
            get
            {
                return GetQueryValue("CourseName").ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.txtCourseCode.Text = BasicCode.NullToString();
            }
        }
        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            if (!TeachingService.IsExitTeachingDetailInfo(BasicCode,this.txtSerialNo.Text.ToInt()))
            {
                TeachingSyllabusDetailUI Teaching = new TeachingSyllabusDetailUI();
                Teaching.CourseCode = BasicCode;
                Teaching.SerialNo = this.txtSerialNo.Text.ToNullableInt();
                Teaching.Title = this.txtTitle.Text;
                Teaching.TheoreticalLessons = this.txtTheoreticalLessons.Text.ToNullableInt();
                Teaching.ExperimentLessons = this.txtExperimentLessons.Text.ToNullableInt();
                Teaching.ExerciseLessons = this.txtExerciseLessons.Text.ToNullableInt();
                Teaching.ComputerLessons = this.txtComputerLessons.Text.ToNullableInt();
                Teaching.TeachingAims = this.txtaTeachingAims.Value;
                Teaching.TeachRequirement = this.txtaTeachRequirement.Value;
                Teaching.Synopsis = this.txtaSynopsis.Value;
                Teaching.TeachKeyPoint = this.txtaTeachKeyPoint.Value;
                Teaching.LessonReview = this.txtaLessonReview.Value;
                TeachingService.AddTeachingSyllabusDetail(Teaching);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                WebMessageBox(this.Page, "'该条教学大纲详细信息已存在！'");

            }
        }
    }
}
