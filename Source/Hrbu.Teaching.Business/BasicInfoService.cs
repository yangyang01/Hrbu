using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.Model;
using Hrbu.Teaching.Model.Convertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.DataAccess;
using Teaching.Model;

namespace Hrbu.Teaching.Business
{
    public class BasicInfoService : IBasicInfo
    {

        public List<BasicInfoUI> GetStudentInfoByPage(QueryStringUI query,int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<BasicInfo>, List<BasicInfoUI>>(StudentBasicInfoContext.GetStudentInfoByPage(EntityMapping.Auto<QueryStringUI, QueryString>(query),startPage, pageSize, out totalCount));
        }


        public List<BasicInfoUI> GetTeacherInfoByPage(QueryStringUI query,int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<BasicInfo>, List<BasicInfoUI>>(TeacherBasicInfoContext.GetTeacherInfoByPage(EntityMapping.Auto<QueryStringUI, QueryString>(query), startPage, pageSize, out totalCount));

        }


        public TeacherBasicInfoUI GetTeacherInfoById(int Id)
        {
            return EntityMapping.Auto<TeacherBasicInfo, TeacherBasicInfoUI>(TeacherBasicInfoContext.GetTeacherInfoById(Id));
        }


        public StudentBasicInfoUI GetStudengInfoById(int Id)
        {
            return EntityMapping.Auto<StudentBasicInfo, StudentBasicInfoUI>(StudentBasicInfoContext.GetStudentInfoById(Id));
        }


        public void UpdateTeacherInfo(TeacherBasicInfoUI teacherInfo)
        {
            var teacher = EntityMapping.Auto<TeacherBasicInfoUI, TeacherBasicInfo>(teacherInfo);
            TeacherBasicInfoContext.Update(teacher);
        }


        public void AddTeacherInfo(TeacherBasicInfoUI teacherInfo)
        {
            var teacher = EntityMapping.Auto<TeacherBasicInfoUI, TeacherBasicInfo>(teacherInfo);
            TeacherBasicInfoContext.Add(teacher);
        }


        public void UpdateStudentInfo(StudentBasicInfoUI studentInfo)
        {
            var student = EntityMapping.Auto<StudentBasicInfoUI, StudentBasicInfo>(studentInfo);
            StudentBasicInfoContext.Update(student);
        }

        public void AddStudentInfo(StudentBasicInfoUI studentInfo)
        {
            var student = EntityMapping.Auto<StudentBasicInfoUI, StudentBasicInfo>(studentInfo);
            StudentBasicInfoContext.Add(student);
        }



        public List<BasicInfoUI> GetTeacherSelfInfoById(string No)
        {
            return EntityMapping.Auto<List<BasicInfo>, List<BasicInfoUI>>(TeacherBasicInfoContext.GetTeacherSelfInfoById(No));
        }


        public List<BasicInfoUI> GetStudentSelfInfoById(string No)
        {
            return EntityMapping.Auto<List<BasicInfo>, List<BasicInfoUI>>(StudentBasicInfoContext.GetStudentSelfInfoById(No));
        }


        public void DeleteTeacherInfo(int Id)
        {
            TeacherBasicInfoContext.Delete(x => x.Id == Id);
        }


        public void DeleteStudentInfo(int Id)
        {
            StudentBasicInfoContext.Delete(x => x.id == Id);
        }


        public bool IsExitStudentNo(string StuNo)
        {
            return StudentBasicInfoContext.IsExitStudentNo(StuNo);
        }


        public bool IsExitTeacherNo(string EmpNo)
        {
            return TeacherBasicInfoContext.IsExitTeacherNo(EmpNo);
        }
    }
}
