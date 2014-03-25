using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.Power;
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
    public class PowerService : IPower
    {
        public List<DataDicUI> GetDataInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<DataDic>, List<DataDicUI>>(DataDicContext.GetDateListByPage(startPage, pageSize, out totalCount));
        }


        public void AddMenu(DataDicUI Data)
        {
            DataDic menuModel = EntityMapping.Auto<DataDicUI, DataDic>(Data);
            DataDicContext.Add(menuModel);
        }

        public List<RoleUI> GetRoleInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<Role>, List<RoleUI>>(RoleContext.GetRoleListByPage(startPage, pageSize, out totalCount));
        }

        public RoleUI GetRoleByRoleId(int Id)
        {
            return EntityMapping.Auto<Role, RoleUI>(RoleContext.GetRoleByRoleId(Id));
        }


        public List<DataDicInfoUI> GetDataDicInfoListById(int Id)
        {
            return EntityMapping.Auto<List<DataDicInfo>, List<DataDicInfoUI>>(DataDicinfoContext.GetDataDicListById(Id));
        }

        public void UpdateDataDic(DataDicInfoUI dataInfo)
        {
            DataDicInfo dataInfoModel = EntityMapping.Auto<DataDicInfoUI, DataDicInfo>(dataInfo);
            DataDicinfoContext.Update(dataInfoModel);
        }


        public void AddDataDic(DataDicInfoUI dataInfo)
        {
            DataDicInfo dataInfoModel = EntityMapping.Auto<DataDicInfoUI, DataDicInfo>(dataInfo);
            DataDicinfoContext.Add(dataInfoModel);
        }


        public DataDicInfoUI GetDataDicInfoById(int Id, int DicId)
        {
            return EntityMapping.Auto<DataDicInfo, DataDicInfoUI>(DataDicinfoContext.GetDataDicInfoById(Id,DicId));
        }


        public List<UserInfoUI> GetUserInfoByPage(QueryStringUI query,int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<UserInfo>, List<UserInfoUI>>(UserContext.GetUserListByPage(EntityMapping.Auto<QueryStringUI, QueryString>(query),startPage,pageSize,out totalCount));

        }


        public void DeleteDataDicInfo(int Id)
        {
            DataDicinfoContext.Delete(x => x.Id == Id);
        }


        public bool RoleHasPermission(string menu, int roleId)
        {
            return AuthorizationsContext.CheckRoleHasPermission(menu, roleId);
        }

        public List<AuthorizationsUI> GetRoleMenus(int roleId)
        {
            return EntityMapping.Auto<List<Authorizations>, List<AuthorizationsUI>>(AuthorizationsContext.GetRoleMenus(roleId));
        }

        public int GetMenuIdByName(string name)
        {
            return AuthorizationsContext.GetMenuIdByName(name);
        }

        public AuthorizationsUI GetAuthInfoByMenuAndRole(string menuName, int roleId)
        {
            return EntityMapping.Auto<Authorizations, AuthorizationsUI>(AuthorizationsContext.GetByConditions(x => x.MenuName == menuName &&
                x.RoleId == roleId).FirstOrDefault());
        }

        public void AddAuth(AuthorizationsUI model)
        {
            AuthorizationsContext.Add(EntityMapping.Auto<AuthorizationsUI, Authorizations>(model));
        }

        public void UpdateAuth(AuthorizationsUI model)
        {
            AuthorizationsContext.Update(EntityMapping.Auto<AuthorizationsUI, Authorizations>(model));
        }

        public UserInfoUI GetUserInfoById(int Id)
        {
            return EntityMapping.Auto<UserInfo, UserInfoUI>(UserContext.GetUserInfoById(Id));
        }


        public void UpdateUser(UserUI user)
        {
            var userInfo=EntityMapping.Auto<UserUI,User>(user);
            UserContext.Update(userInfo);
        }

        public void AddUser(UserUI user)
        {
            var userInfo = EntityMapping.Auto<UserUI, User>(user);
            UserContext.Add(userInfo);
        }

        public void DeleteUser(int id)
        {
            UserContext.Delete(x=>x.Id==id);
        }


        public List<DataDicInfoUI> GetDataDicByType(int type)
        {
            return EntityMapping.Auto<List<DataDicInfo>, List<DataDicInfoUI>>(DataDicinfoContext.GetDataDicByType(type));
        }


        public List<RoleUI> GetRoleNameList()
        {
            return EntityMapping.Auto<List<Role>, List<RoleUI>>(RoleContext.GetRoleNameList());
        }


        public bool IsExitUserNo(string UserNo)
        {
            return UserContext.IsExitUserNo(UserNo);
        }


        public List<UserUI> GetUserList()
        {
            return EntityMapping.Auto<List<User>, List<UserUI>>(UserContext.GetUserList());
        }


        public bool IsStudentNo(int roleId)
        {
            return UserContext.IsStudentNo(roleId);
        }


        public UserUI GetUserInfoByNo(string stuNo)
        {
            return EntityMapping.Auto<User, UserUI>(UserContext.GetUserInfoByNo(stuNo));
        }
    }
}
