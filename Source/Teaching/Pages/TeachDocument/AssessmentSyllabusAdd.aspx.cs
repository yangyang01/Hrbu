using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.WebUI.Code;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;

namespace Teaching.Pages.TeachDocument
{
    public partial class AssessmentSyllabusAdd : BasePage
    {
        public ITeachDocument AssessmentService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlEvaluationMode.BindDropDownListWithDefault(9);
                this.ddlAssessmentType.BindDropDownListWithDefault(11);
            }

        }
        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            if (!AssessmentService.IsExitCourseCode(this.txtCourseCode.Text.ToInt()))
            {
                WebMessageBox(this.Page, "'请确定是否存在该课程！'");
            }
            else
            {
                if (!AssessmentService.IsExitAssessmentInfo(this.txtCourseCode.Text.ToInt()))
                {
                    AssessmentSyllabusBasicUI Teaching = new AssessmentSyllabusBasicUI();
                    Teaching.CourseCode = this.txtCourseCode.Text.ToNullableInt();
                    Teaching.EvaluationMode = this.ddlEvaluationMode.SelectedValue.ToNullableInt();
                    Teaching.AssessmentType = this.ddlAssessmentType.SelectedValue.ToNullableInt();
                    Teaching.SOTopicProportion = this.txtSOTopicProportion.Text;
                    Teaching.CourseCode = this.txtCourseCode.Text.ToInt();
                    Teaching.TopicProportion = this.txtTopicProportion.Text;
                    Teaching.DifficultyLevel = this.txtDifficultyLevel.Text;
                    Teaching.AssessmentPurpose = this.txtaAssessmentPurpose.Value;
                    Teaching.CourseFoundation = this.txtaCourseFoundation.Value;
                    Teaching.InspectionScope = this.txtaInspectionScope.Value;
                    Teaching.TestRequirements = this.txtaTestRequirements.Value;
                    AssessmentService.AddAssessmentSyllabusBasic(Teaching);
                    WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
                }
                else
                {
                    WebMessageBox(this.Page, "'该课程考核大纲已存在！'");

                }
            }
        }
    }
}