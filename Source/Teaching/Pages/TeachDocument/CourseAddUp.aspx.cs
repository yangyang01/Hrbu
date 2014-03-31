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
using Hrbu.Teaching.BusinessView.Model.TeachDocument;

namespace Teaching.Pages.TeachDocument
{
    public partial class CourseAddUp : BasePage
    {
        public ITeachDocument CourseService { get; set; }
        public int Id
        {
            get
            {
                return GetQueryValue("Id").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlCourseType.BindDropDownListWithDefault(6);
                this.ddlCourseProperty.BindDropDownListWithDefault(7);
                if (Request["Id"] != null)
                {
                    BindModel();
                }
            }
        }
        protected void BindModel()
        {
            var courseInfo = CourseService.GetCourseInfoById(Id);
            this.txtCourseNo.Text = courseInfo.CourseCode.NullToString();
            this.txtCourseName.Text = courseInfo.CourseName;
            this.ddlCourseProperty.SelectedValue = courseInfo.CourseProperty.NullToString();
            this.ddlCourseType.SelectedValue = courseInfo.CourseType.NullToString();
            this.txtCredit.Text = courseInfo.Credit.NullToString();
            this.txtPeriodTotal.Text = courseInfo.PeriodTotal.NullToString();
        }
        protected void ClickbtnSure(object sender, EventArgs e)
        {
            if (Request["Id"] != null)
            {
                var courseInfo = CourseService.GetCourseInfoById(Id);

                courseInfo.CourseCode = this.txtCourseNo.Text.ToNullableInt();
                courseInfo.CourseName = this.txtCourseName.Text;
                courseInfo.CourseProperty = this.ddlCourseProperty.SelectedValue.ToInt();
                courseInfo.CourseType = this.ddlCourseType.SelectedValue.ToInt();
                courseInfo.Credit = this.txtCredit.Text.ToNullableInt();
                courseInfo.PeriodTotal = this.txtPeriodTotal.Text.ToNullableInt();
                CourseService.UpdateCourse(courseInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                if (!CourseService.IsExitCourseCode(this.txtCourseNo.Text.ToInt()))
                {
                    CourseInfoUI courseInfo = new CourseInfoUI();
                    courseInfo.CourseCode = this.txtCourseNo.Text.ToNullableInt();
                    courseInfo.CourseName = this.txtCourseName.Text;
                    courseInfo.CourseProperty = this.ddlCourseProperty.SelectedValue.ToInt();
                    courseInfo.CourseType = this.ddlCourseType.SelectedValue.ToInt();
                    courseInfo.Credit = this.txtCredit.Text.ToNullableInt();
                    courseInfo.PeriodTotal = this.txtPeriodTotal.Text.ToNullableInt();
                    CourseService.AddCourse(courseInfo);
                    WebMessageBox(this.Page, string.Format("'添加成功!',RefreshParentAndCloseSelf"));
                }
                else
                {
                    WebMessageBox(this.Page, "'该课程已存在!'");
                }
            }
        }
    }
}