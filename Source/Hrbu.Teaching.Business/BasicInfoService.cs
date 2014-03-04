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
    public class BasicInfoService:IBasicInfo
    {

        public List<StudentBasicInfoUI> GetStudentInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<StudentBasicInfo>, List<StudentBasicInfoUI>>(StudentBasicInfoContext.GetStudentInfoByPage(startPage, pageSize, out totalCount));
        }


       public List<TeacherBasicInfoUI> GetTeacherInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<TeacherBasicInfo>, List<TeacherBasicInfoUI>>(TeacherBasicInfoContext.GetTeacherInfoByPage(startPage, pageSize, out totalCount));

        }


       public TeacherBasicInfoUI GetTeacherInfoById(int Id)
       {
           return EntityMapping.Auto<TeacherBasicInfo, TeacherBasicInfoUI>(TeacherBasicInfoContext.GetTeacherInfoById(Id));
       }


       public StudentBasicInfoUI GetStudengInfoById(int Id)
       {
           return EntityMapping.Auto<StudentBasicInfo, StudentBasicInfoUI>(StudentBasicInfoContext.GetStudentInfoById(Id));
       }
    }
}
