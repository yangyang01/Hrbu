using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using Hrbu.Teaching.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.Interface
{
    [ServiceContract]
    public partial interface ITeachDocument
    {
        /// <summary>
        /// 获得课程名的下拉列表
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<CourseInfoUI> GetCourseNameList();
        /// <summary>
        /// 添加人才培养方案目标
        /// </summary>
        /// <param name="TrainingProgramAim"></param>
        [OperationContract]
        void AddTrainingProgramAimInfo(TrainingProgramAimUI TrainingProgramAim);
        /// <summary>
        /// 添加人才培养方案课程信息
        /// </summary>
        /// <param name="TrainingProgramInfo"></param>
        void AddTrainingProgramAimInfo(TrainingProgramInfoUI TrainingProgramInfo);
        /// <summary>
        /// 获得课程的分页列表
        /// </summary>
        /// <param name="query"></param>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<CourseUI> GetCourseInfoByPage(QueryStringUI query, int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 根据课程id删除课程
        /// </summary>
        /// <param name="Id"></param>
        void DeleteCourse(int Id);
        /// <summary>
        /// 根据Id获取课程对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CourseInfoUI GetCourseInfoById(int id);
        /// <summary>
        /// 修改课程信息
        /// </summary>
        /// <param name="course"></param>
        void UpdateCourse(CourseInfoUI course);
        /// <summary>
        /// 添加课程信息
        /// </summary>
        /// <param name="course"></param>
        void AddCourse(CourseInfoUI course);
        /// <summary>
        /// 判断是否存在该课程
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool IsExitCourseCode(int code);
        /// <summary>
        /// 判断是否存在该学年学期的该课程培养方案
        /// </summary>
        /// <param name="SchoolYear"></param>
        /// <param name="SchoolSemester"></param>
        /// <param name="CourseCode"></param>
        /// <returns></returns>
        bool IsExitTrainInfo(int SchoolYear, int SchoolSemester, int CourseCode, int Grade);
        /// <summary>
        /// 获取培养方案目标列表
        /// </summary>
        /// <param name="query"></param>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TrainingProgramAimUI> GetTrainAimByPage(QueryStringUI query, int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 获取培养方案课程列表
        /// </summary>
        /// <param name="query"></param>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TrainingProgramCourseInfoUI> GetTrainCourseByPage(QueryStringUI query, int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 判断是否存在该课程的教学大纲
        /// </summary>
        /// <param name="CourseCode"></param>
        /// <returns></returns>
        bool IsExitTeachingInfo(int CourseCode);
        /// <summary>
        /// 添加教学大纲基本信息
        /// </summary>
        /// <param name="TeachingSyllabusBasic"></param>
        void AddTeachingSyllabusBasic(TeachingSyllabusBasicUI TeachingSyllabusBasic);
        /// <summary>
        /// 添加教学大纲详细信息
        /// </summary>
        /// <param name="TeachingSyllabusDetail"></param>
        void AddTeachingSyllabusDetail(TeachingSyllabusDetailUI TeachingSyllabusDetail);
        /// <summary>
        /// 教学大纲基本信息的分页列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TeachingSyllabusInfoUI> GetTeachingSyllabusByPage(int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 是否已经存在该条教学大纲详细信息
        /// </summary>
        /// <param name="SerialNo"></param>
        /// <returns></returns>
        bool IsExitTeachingDetailInfo(int CourseCode, int SerialNo);
        /// <summary>
        /// 获取教学大纲详细内容列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TeachingSyllabusInfoUI> GetTeachingSyllabusDetailByPage(int CourseCode, int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 添加考核大纲基本信息
        /// </summary>
        /// <param name="AssessmentSyllabusBasic"></param>
        void AddAssessmentSyllabusBasic(AssessmentSyllabusBasicUI AssessmentSyllabusBasic);
        /// <summary>
        /// 添加考核大纲详细信息
        /// </summary>
        /// <param name="AssessmentSyllabusDetail"></param>
        void AddAssessmentSyllabusDetail(AssessmentSyllabusDetailUI AssessmentSyllabusDetail);
        /// <summary>
        /// 是否存在该课程的考核大纲
        /// </summary>
        /// <param name="CourseCode"></param>
        /// <returns></returns>
        bool IsExitAssessmentInfo(int CourseCode);
        /// <summary>
        /// 是否存在改门课程的该章节考核大纲
        /// </summary>
        /// <param name="CourseCode"></param>
        /// <param name="Chapter"></param>
        /// <returns></returns>
        bool IsExitAssessmentDetailInfo(int CourseCode, string Chapter);
        /// <summary>
        /// 获取考核大纲基本信息列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<AssessmentSyllabusBasicUI> GetAssessmentSyllabusByPage(int startPage, int pageSize, out int totalCount);
        
    }
}
