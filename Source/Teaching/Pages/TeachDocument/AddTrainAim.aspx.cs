using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.WebUI.Code;

namespace Teaching.Pages.TeachDocument
{
    public partial class AddTrainAim : BasePage
    {
        public ITeachDocument DocumentService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlGrade.BindDropDownListWithDefault(4);
                this.ddlYear.BindDropDownListWithDefault(5);
                this.ddlSemester.BindDropDownListWithDefault(10);

            }
        }
        protected void BindModel()
        {



        }
        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            TrainingProgramAimUI Training = new TrainingProgramAimUI();
            Training.SchoolYear = this.ddlYear.SelectedValue.ToNullableInt();
            Training.SchoolSemester = this.ddlSemester.SelectedValue.ToNullableInt();
            Training.Grade = this.ddlGrade.SelectedValue.ToNullableInt();
            Training.TrainAim = this.txtaAim.Value;
            Training.SpecificationRequirements = this.txtaRequirements.Value;
            Training.LearningDegree = this.txtaLearningDegree.Value;
            Training.TeachingPlatform = this.txtaPlatform.Value;
            Training.ProfessionalPlatform = this.txtaProfessional.Value;
            Training.PracticalPlatform = this.txtaPractical.Value;
            DocumentService.AddTrainingProgramAimInfo(Training);
            WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
        }

    }
}