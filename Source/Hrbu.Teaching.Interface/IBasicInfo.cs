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
        List<BasicInfoUI> GetStudentInfoByPage(QueryStringUI query,int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 获取教师信息的列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<BasicInfoUI> GetTeacherInfoByPage(QueryStringUI query,int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 根据教师Id获取教师详细信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        TeacherBasicInfoUI GetTeacherInfoById(int Id);
        /// <summary>
        /// 根据学生Id获取学生的详细信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        StudentBasicInfoUI GetStudengInfoById(int Id);
        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="teacherInfo"></param>
        void UpdateTeacherInfo(TeacherBasicInfoUI teacherInfo);
        /// <summary>
        /// 添加教师信息
        /// </summary>
        /// <param name="teacherInfo"></param>
        void AddTeacherInfo(TeacherBasicInfoUI teacherInfo);
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="studentInfo"></param>
        void UpdateStudentInfo(StudentBasicInfoUI studentInfo);
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="studentInfo"></param>
        void AddStudentInfo(StudentBasicInfoUI studentInfo);
        /// <summary>
        /// 当非管理员进入时获取的教师列表
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        List<BasicInfoUI> GetTeacherSelfInfoById(string No);
        /// <summary>
        /// 当非管理员进入时获取的学生列表
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        List<BasicInfoUI> GetStudentSelfInfoById(string No);
        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="Id"></param>
        void DeleteTeacherInfo(int Id);
        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="Id"></param>
        void DeleteStudentInfo(int Id);
        /// <summary>
        /// 是否存在该学生信息
        /// </summary>
        /// <param name="UserNo"></param>
        /// <returns></returns>
        bool IsExitStudentNo(string StuNo);
        /// <summary>
        /// 是否存在该教师对象
        /// </summary>
        /// <param name="EmpNo"></param>
        /// <returns></returns>
        bool IsExitTeacherNo(string EmpNo);

    }
}
