using AutoMapper;
using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.BusinessView.Model.Power;
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
            Mapper.CreateMap<StudentInfo, StudentInfoUI>();
            Mapper.CreateMap<StudentInfoUI, StudentInfo>();

            #region Power
            Mapper.CreateMap<Role, RoleUI>();
            Mapper.CreateMap<RoleUI, Role>();
            Mapper.CreateMap<User, UserUI>();
            Mapper.CreateMap<UserUI, User>();
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
            #endregion
            Mapper.CreateMap<Authorizations, AuthorizationUI>();
            Mapper.CreateMap<AuthorizationUI, Authorizations>();

        }
    }
}
