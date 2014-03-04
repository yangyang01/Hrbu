using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;

namespace Teaching.Pages.BasicInfo
{
    public partial class TeacherInfoDetail : BasePage
    {
        public IBasicInfo TeacherService { get; set; }

        public int TeacherId
        {
            get
            {
                return GetQueryValue("TeacherId").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindModel();
            }
        }
        protected void BindModel()
        {
            var teacherInfo = TeacherService.GetTeacherInfoById(TeacherId);
            this.txtEmpNo.Text = teacherInfo.EmpNo;
            this.txtEmpName.Text = teacherInfo.Name;
            this.txtsex.Text = teacherInfo.Sex;
            this.txtPost.Text = teacherInfo.PATP;
            this.txtCourseOne.Text = teacherInfo.Course1;
            this.txtCourseTwo.Text = teacherInfo.Course2;
            this.txtCoursethree.Text = teacherInfo.Course3;
            this.txtCourseFour.Text = teacherInfo.Course4;
            this.txtHighBackground.Text = teacherInfo.HightestDegree;
            this.txtFinishSchool.Text = teacherInfo.GraduationSchool;
            this.txtTel.Text = teacherInfo.Tel;
            this.txtMail.Text = teacherInfo.Mail;
            this.txtCurriculumVitae.Value = teacherInfo.IndividualResume;
            
            
        }
    }
}