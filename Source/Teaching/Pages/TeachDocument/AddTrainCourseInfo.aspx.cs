using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.WebUI.Code;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.Interface;


namespace Teaching.Pages.TeachDocument
{
    public partial class AddTrainCourseInfo : BasePage
    {
        public ITeachDocument DocumentService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlGrade.BindDropDownListWithDefault(4);
                this.ddlYear.BindDropDownListWithDefault(5);
                this.ddlMarjor.BindDropDownListWithDefault(8);
                this.ddlEvaluation.BindDropDownListWithDefault(9);
                this.ddlSemester.BindDropDownListWithDefault(10);
            }
        }
        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            if (!DocumentService.IsExitCourseCode(this.txtCourseCode.Text.ToInt()))
            {
                WebMessageBox(this.Page, "'请确定是否存在该课程！'");
            }
            else
            {
                if (!DocumentService.IsExitTrainInfo(this.ddlYear.SelectedValue.ToInt(), this.ddlSemester.SelectedValue.ToInt(),
                    this.txtCourseCode.Text.ToInt(), this.ddlGrade.SelectedValue.ToInt()))
                {
                    TrainingProgramInfoUI Training = new TrainingProgramInfoUI();
                    Training.SchoolYear = this.ddlYear.SelectedValue.ToNullableInt();
                    Training.SchoolSemester = this.ddlSemester.SelectedValue.ToNullableInt();
                    Training.Grade = this.ddlGrade.SelectedValue.ToNullableInt();
                    Training.ProfessionalEmphasis = this.ddlMarjor.SelectedValue.ToNullableInt();
                    Training.CourseCode = this.txtCourseCode.Text.ToInt();
                    Training.TeachingPeriod = this.txtTeachPeriod.Text.ToInt();
                    Training.ExperimentPeriod = this.txtTestPeriod.Text.ToInt();
                    Training.PracticeWeeks = this.txtPracticeWeeks.Text.ToInt();
                    Training.EvaluationMode = this.ddlEvaluation.SelectedValue.ToNullableInt();
                    Training.Remark = this.txtaRemark.Value;
                    DocumentService.AddTrainingProgramAimInfo(Training);
                    WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
                }
                else
                {
                    WebMessageBox(this.Page, "'该学年学期的该年级课程培养方案已存在！'");

                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }
    }
}