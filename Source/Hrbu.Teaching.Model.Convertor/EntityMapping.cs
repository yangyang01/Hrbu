using AutoMapper;
using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Hrbu.Teaching.Model.Convertor
{
    public class EntityMapping
    {
        public static T2 Auto<T1, T2>(T1 originEntity, T2 defaultValue = default(T2))
        {
            if (originEntity == null)
            {
                if (defaultValue != null)
                    return defaultValue;
            }
            return Mapper.Map<T1, T2>(originEntity);
        }
        static EntityMapping()
        {
            #region Power
            Mapper.CreateMap<Authorizations, AuthorizationsUI>();
            Mapper.CreateMap<AuthorizationsUI, Authorizations>();
            Mapper.CreateMap<Role, RoleUI>();
            Mapper.CreateMap<RoleUI, Role>();
            Mapper.CreateMap<User, UserUI>();
            Mapper.CreateMap<UserUI, User>();
            Mapper.CreateMap<UserInfo, UserInfoUI>();
            Mapper.CreateMap<UserInfoUI, UserInfo>();
            Mapper.CreateMap<Menu, MenuUI>();
            Mapper.CreateMap<MenuUI, Menu>();
            Mapper.CreateMap<DataDic, DataDicUI>();
            Mapper.CreateMap<DataDicUI, DataDic>();
            Mapper.CreateMap<DataDicInfo, DataDicInfoUI>();
            Mapper.CreateMap<DataDicInfoUI, DataDicInfo>();
            #endregion

            #region BasicInfo
            Mapper.CreateMap<TeacherBasicInfo, TeacherBasicInfoUI>();
            Mapper.CreateMap<TeacherBasicInfoUI, TeacherBasicInfo>();
            Mapper.CreateMap<StudentBasicInfo, StudentBasicInfoUI>();
            Mapper.CreateMap<StudentBasicInfoUI, StudentBasicInfo>();
            Mapper.CreateMap<BasicInfo, BasicInfoUI>();
            Mapper.CreateMap<BasicInfoUI, BasicInfo>();

            #endregion
           
            #region TeachDocument
            Mapper.CreateMap<Course, CourseUI>();
            Mapper.CreateMap<CourseUI, Course>();
            Mapper.CreateMap<CourseInfo, CourseInfoUI>();
            Mapper.CreateMap<CourseInfoUI, CourseInfo>();
            Mapper.CreateMap<TrainingProgramAim, TrainingProgramAimUI>();
            Mapper.CreateMap<TrainingProgramAimUI, TrainingProgramAim>();
            Mapper.CreateMap<TrainingProgramInfo, TrainingProgramInfoUI>();
            Mapper.CreateMap<TrainingProgramInfoUI, TrainingProgramInfo>();
            Mapper.CreateMap<TrainingProgramCourseInfo, TrainingProgramCourseInfoUI>();
            Mapper.CreateMap<TrainingProgramCourseInfoUI, TrainingProgramCourseInfo>();
            Mapper.CreateMap<TeachingSyllabusBasic, TeachingSyllabusBasicUI>();
            Mapper.CreateMap<TeachingSyllabusBasicUI, TeachingSyllabusBasic>();
            Mapper.CreateMap<TeachingSyllabusDetail, TeachingSyllabusDetailUI>();
            Mapper.CreateMap<TeachingSyllabusDetailUI, TeachingSyllabusDetail>();
            #endregion
            Mapper.CreateMap<QueryString, QueryStringUI>();
            Mapper.CreateMap<QueryStringUI, QueryString>();
        }
    }
}
