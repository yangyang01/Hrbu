using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.WebUI.Code;

namespace Teaching.Pages.BasicInfo
{
    public partial class TeacherInfoDetail : BasePage
    {
        public IBasicInfo TeacherService { get; set; }
        public IPower UserService { get; set; }

        public int TeacherId
        {
            get
            {
                return GetQueryValue("TeacherId").ToInt();
            }
        }
        protected string Status
        {
            get
            {
                return GetQueryValue("Status");
            }
        }

        public bool IsView
        {
            get
            {
                return Status.ToUpper() == "View" || string.IsNullOrEmpty(Status);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["TeacherId"] != null)
                {
                    BindModel();
                    this.ddlPATP.BindDropDownListWithDefault(1);

                }
                if (IsView)
                {
                    this.btnSubmit.Visible = true;
                    this.btnReset.Visible = true;
                }
                this.ddlMajor.BindDropDownListWithDefault(3);
                this.ddlCollage.BindDropDownListWithDefault(2);
                this.ddlPATP.BindDropDownListWithDefault(1);
                this.ddlCourse1.BindCourseDropDownListWithDefault();
                this.ddlCourse2.BindCourseDropDownListWithDefault();
                this.ddlCourse3.BindCourseDropDownListWithDefault();
                this.ddlCourse4.BindCourseDropDownListWithDefault();

            }
        }
        protected void BindModel()
        {
            var teacherInfo = TeacherService.GetTeacherInfoById(TeacherId);
            this.txtEmpNo.Text = teacherInfo.EmpNo;
            this.txtsex.Text = teacherInfo.Sex;
            this.ddlMajor.SelectedValue = teacherInfo.Major.NullToString();
            this.ddlCollage.SelectedValue = teacherInfo.Collage.NullToString();
            this.ddlPATP.SelectedValue = teacherInfo.PATP.NullToString();
            this.ddlCourse1.SelectedValue = teacherInfo.Course1.NullToString();
            this.ddlCourse2.SelectedValue = teacherInfo.Course2.NullToString();
            this.ddlCourse3.SelectedValue = teacherInfo.Course3.NullToString();
            this.ddlCourse4.SelectedValue = teacherInfo.Course4.NullToString();
            this.txtHighBackground.Text = teacherInfo.HightestDegree;
            this.txtFinishSchool.Text = teacherInfo.GraduationSchool;
            this.txtTel.Text = teacherInfo.Tel;
            this.txtMail.Text = teacherInfo.Mail;
            this.txtCurriculumVitae.Value = teacherInfo.IndividualResume;
        }

        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            if (Request["TeacherId"] != null)
            {
                var teacherInfo = TeacherService.GetTeacherInfoById(TeacherId);

                teacherInfo.EmpNo = this.txtEmpNo.Text;
                teacherInfo.Sex = this.txtsex.Text;
                teacherInfo.PATP = this.ddlPATP.SelectedValue.ToNullableInt();
                teacherInfo.Collage = this.ddlCollage.SelectedValue.ToNullableInt();
                teacherInfo.Major = this.ddlMajor.SelectedValue.ToNullableInt();
                teacherInfo.Course1 = this.ddlCourse1.SelectedValue.ToNullableInt();
                teacherInfo.Course2 = this.ddlCourse2.SelectedValue.ToNullableInt();
                teacherInfo.Course3 = this.ddlCourse3.SelectedValue.ToNullableInt();
                teacherInfo.Course4 = this.ddlCourse4.SelectedValue.ToNullableInt();
                teacherInfo.HightestDegree = this.txtHighBackground.Text;
                teacherInfo.GraduationSchool = this.txtFinishSchool.Text;
                teacherInfo.Tel = this.txtTel.Text;
                teacherInfo.Mail = this.txtMail.Text;
                teacherInfo.IndividualResume = this.txtCurriculumVitae.Value;
                TeacherService.UpdateTeacherInfo(teacherInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                if (!UserService.IsExitUserNo(this.txtEmpNo.Text))
                {
                    WebMessageBox(this.Page, "'请确定存在该用户！'");
                }
                else
                {
                    var user = UserService.GetUserInfoByNo(this.txtEmpNo.Text);
                    if (UserService.IsStudentNo(user.RoleId))
                    {
                        WebMessageBox(this.Page, "'请确定该用户为教工用户！'");
                    }
                    else
                    {
                        if (!TeacherService.IsExitTeacherNo(this.txtEmpNo.Text))
                        {
                            TeacherBasicInfoUI teacherInfo = new TeacherBasicInfoUI();
                            teacherInfo.EmpNo = this.txtEmpNo.Text;
                            teacherInfo.Name = user.UserName;
                            teacherInfo.Sex = this.txtsex.Text;
                            teacherInfo.Collage = this.ddlCollage.SelectedValue.ToNullableInt();
                            teacherInfo.Major = this.ddlMajor.SelectedValue.ToNullableInt();
                            teacherInfo.PATP = this.ddlPATP.SelectedValue.ToNullableInt();
                            teacherInfo.Course1 = this.ddlCourse1.SelectedValue.ToNullableInt();
                            teacherInfo.Course2 = this.ddlCourse2.SelectedValue.ToNullableInt();
                            teacherInfo.Course3 = this.ddlCourse3.SelectedValue.ToNullableInt();
                            teacherInfo.Course4 = this.ddlCourse4.SelectedValue.ToNullableInt();
                            teacherInfo.HightestDegree = this.txtHighBackground.Text;
                            teacherInfo.GraduationSchool = this.txtFinishSchool.Text;
                            teacherInfo.Tel = this.txtTel.Text;
                            teacherInfo.Mail = this.txtMail.Text;
                            teacherInfo.IndividualResume = this.txtCurriculumVitae.Value;
                            TeacherService.AddTeacherInfo(teacherInfo);
                            WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
                        }
                    }
                }
            }
        }
    }
}