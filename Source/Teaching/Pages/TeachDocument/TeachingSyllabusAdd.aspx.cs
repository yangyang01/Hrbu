using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using Hrbu.Teaching.WebUI.Code;

namespace Teaching.Pages.TeachDocument
{
    public partial class TeachingSyllabusAdd : BasePage
    {
        public ITeachDocument TeachingService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlPrerequisiteCourse.BindCourseDropDownListWithDefault();
            }
        }
        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            if (!TeachingService.IsExitCourseCode(this.txtCourseCode.Text.ToInt()))
            {
                WebMessageBox(this.Page, "'请确定是否存在该课程！'");
            }
            else
            {
                if (!TeachingService.IsExitTeachingInfo(this.txtCourseCode.Text.ToInt()))
                {
                    TeachingSyllabusBasicUI Teaching = new TeachingSyllabusBasicUI();
                    Teaching.CourseCode = this.txtCourseCode.Text.ToNullableInt();
                    Teaching.PrerequisiteCourse = this.ddlPrerequisiteCourse.SelectedValue.ToNullableInt();
                    Teaching.Textbook = this.txtTextbook.Text;
                    Teaching.ReferenceBook = this.txtReferenceBook.Text;
                    Teaching.CourseCode = this.txtCourseCode.Text.ToInt();
                    Teaching.TeachAim = this.txtaTeachAim.Value;
                    Teaching.TeachTask = this.txtaTeachTask.Value;
                    Teaching.TeachContent = this.txtaTeachContent.Value;
                    Teaching.TeachMethod = this.txtaTeachMethod.Value;
                    Teaching.TeachPrinciple = this.txtaTeachPrinciple.Value;
                    TeachingService.AddTeachingSyllabusBasic(Teaching);
                    WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
                }
                else
                {
                    WebMessageBox(this.Page, "'该课程教学大纲已存在！'");

                }
            }
        }

    }
}