using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.Interface
{
    [ServiceContract]
    public interface IBasicInfo
    {
        /// <summary>
        /// 获取学生信息的列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        [OperationContract]
        List<StudentBasicInfoUI> GetStudentInfoByPage(int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 获取教师信息的列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TeacherBasicInfoUI> GetTeacherInfoByPage(int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 根据教师Id获取教师详细信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        TeacherBasicInfoUI GetTeacherInfoById(int Id);

    }
}
