using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;
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
    public class TeachDocumentService : ITeachDocument
    {

        public List<CourseInfoUI> GetCourseNameList()
        {
            return EntityMapping.Auto<List<CourseInfo>, List<CourseInfoUI>>(CourseInfoContext.GetCourseNameList());
        }


        public void AddTrainingProgramAimInfo(TrainingProgramAimUI TrainingProgramAim)
        {
            var Training = EntityMapping.Auto<TrainingProgramAimUI, TrainingProgramAim>(TrainingProgramAim);
            TrainingProgramAimContext.Add(Training);
        }


        public void AddTrainingProgramAimInfo(TrainingProgramInfoUI TrainingProgramInfo)
        {
            var Training = EntityMapping.Auto<TrainingProgramInfoUI, TrainingProgramInfo>(TrainingProgramInfo);
            TrainingProgramInfoContext.Add(Training);
        }


        public List<CourseUI> GetCourseInfoByPage(QueryStringUI query, int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<Course>, List<CourseUI>>(CourseInfoContext.GetCourseInfoByPage(EntityMapping.Auto<QueryStringUI, QueryString>(query), startPage, pageSize, out totalCount));
        }


        public void DeleteCourse(int Id)
        {
            CourseInfoContext.Delete(x => x.Id == Id);
        }


        public CourseInfoUI GetCourseInfoById(int id)
        {
            return EntityMapping.Auto<CourseInfo, CourseInfoUI>(CourseInfoContext.GetCourseInfoById(id));
        }


        public void UpdateCourse(CourseInfoUI course)
        {
            var courseInfo = EntityMapping.Auto<CourseInfoUI, CourseInfo>(course);
            CourseInfoContext.Update(courseInfo);
        }

        public void AddCourse(CourseInfoUI course)
        {
            var courseInfo = EntityMapping.Auto<CourseInfoUI, CourseInfo>(course);
            CourseInfoContext.Add(courseInfo);
        }

        public bool IsExitCourseCode(int code)
        {
            return CourseInfoContext.IsExitCourseCode(code);
        }


        public bool IsExitTrainInfo(int SchoolYear, int SchoolSemester, int CourseCode,int Grade)
        {
            return TrainingProgramInfoContext.IsExitTrainInfo(SchoolYear,SchoolSemester,CourseCode,Grade);
        }


        public List<TrainingProgramAimUI> GetTrainAimByPage(QueryStringUI query, int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<TrainingProgramAim>, List<TrainingProgramAimUI>>(TrainingProgramAimContext.GetTrainAimByPage(EntityMapping.Auto<QueryStringUI, QueryString>(query), startPage, pageSize,out totalCount));
        }

        public List<TrainingProgramCourseInfoUI> GetTrainCourseByPage(QueryStringUI query, int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<TrainingProgramCourseInfo>, List<TrainingProgramCourseInfoUI>>(TrainingProgramInfoContext.GetTrainCourseByPage(EntityMapping.Auto<QueryStringUI, QueryString>(query), startPage, pageSize, out totalCount));

        }



        public bool IsExitTeachingInfo(int CourseCode)
        {
            return TeachingSyllabusBasicContext.IsExitTeachingInfo(CourseCode);

        }


        public void AddTeachingSyllabusBasic(TeachingSyllabusBasicUI TeachingSyllabusBasic)
        {
            var Info = EntityMapping.Auto<TeachingSyllabusBasicUI, TeachingSyllabusBasic>(TeachingSyllabusBasic);

            TeachingSyllabusBasicContext.Add(Info);
        }

        public void AddTeachingSyllabusDetail(TeachingSyllabusDetailUI TeachingSyllabusDetail)
        {
            var Info = EntityMapping.Auto<TeachingSyllabusDetailUI, TeachingSyllabusDetail>(TeachingSyllabusDetail);

            TeachingSyllabusDetailContext.Add(Info);
        }


        public List<TeachingSyllabusInfoUI> GetTeachingSyllabusByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<TeachingSyllabusInfo>,List<TeachingSyllabusInfoUI>>(TeachingSyllabusBasicContext.GetTeachingSyllabusByPage(startPage,pageSize, out totalCount));
        }


        public bool IsExitTeachingDetailInfo(int CourseCode, int SerialNo)
        {
            return TeachingSyllabusDetailContext.IsExitTeachingDetailInfo(CourseCode,SerialNo);
        }


        public List<TeachingSyllabusInfoUI> GetTeachingSyllabusDetailByPage(int CourseCode, int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<TeachingSyllabusInfo>, List<TeachingSyllabusInfoUI>>(TeachingSyllabusDetailContext.GetTeachingSyllabusDetailByPage(CourseCode,startPage, pageSize, out totalCount));

        }


        public void AddAssessmentSyllabusBasic(AssessmentSyllabusBasicUI AssessmentSyllabusBasic)
        {
            var Info = EntityMapping.Auto<AssessmentSyllabusBasicUI, AssessmentSyllabusBasic>(AssessmentSyllabusBasic);

            AssessmentSyllabusBasicContext.Add(Info);
        }

        public void AddAssessmentSyllabusDetail(AssessmentSyllabusDetailUI AssessmentSyllabusDetail)
        {
            var Info = EntityMapping.Auto<AssessmentSyllabusDetailUI, AssessmentSyllabusDetail>(AssessmentSyllabusDetail);

            AssessmentSyllabusDetailContext.Add(Info);
        }

        public bool IsExitAssessmentInfo(int CourseCode)
        {
            return AssessmentSyllabusBasicContext.IsExitAssessmentInfo(CourseCode);
        }

        public bool IsExitAssessmentDetailInfo(int CourseCode, string Chapter)
        {
            return AssessmentSyllabusDetailContext.IsExitAssessmentDetailInfo(CourseCode, Chapter);

        }


        public List<AssessmentSyllabusBasicUI> GetAssessmentSyllabusByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<AssessmentSyllabusBasic>, List<AssessmentSyllabusBasicUI>>(AssessmentSyllabusBasicContext.GetAssessmentSyllabusByPage(startPage, pageSize, out totalCount));

        }
    }
}
