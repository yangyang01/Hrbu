using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.BusinessView.Model.Power;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.Interface
{
    [ServiceContract]
    public interface IPower
    {
        /// <summary>
        /// 获得数据字典列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        [OperationContract]
        List<DataDicUI> GetDataInfoByPage(int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 增加数据字典
        /// </summary>
        /// <param name="Data"></param>
        [OperationContract]
        void AddMenu(DataDicUI Data);
        /// <summary>
        /// 获得角色列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<RoleUI> GetRoleInfoByPage(int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 根据角色Id获取菜单列表页的角色名
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [OperationContract]
        RoleUI GetRoleByRoleId(int Id);
        /// <summary>
        /// 根据数据字典ID获取具体数据项的列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<DataDicInfoUI> GetDataDicInfoListById(int Id);
        /// <summary>
        /// 修改数据字典数据信息
        /// </summary>
        /// <param name="dataInfo"></param>
        [OperationContract]
        void UpdateDataDic(DataDicInfoUI dataInfo);
        /// <summary>
        /// 新增数据字典数据
        /// </summary>
        /// <param name="dataInfo"></param>
        [OperationContract]
        void AddDataDic(DataDicInfoUI dataInfo);
        /// <summary>
        /// 根据Id获取数据字典数据对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [OperationContract]
        DataDicInfoUI GetDataDicInfoById(int Id,int DicId);
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="startPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        [OperationContract]
        List<UserInfoUI> GetUserInfoByPage(int startPage, int pageSize, out int totalCount);
        /// <summary>
        /// 删除数据字典数据
        /// </summary>
        /// <param name="DataInfo"></param>
        [OperationContract]
        void DeleteDataDicInfo(int Id);
        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [OperationContract]
        UserInfoUI GetUserInfoById(int Id);

        bool RoleHasPermission(string menu, int roleId);

        List<AuthorizationsUI> GetRoleMenus(int roleId);
        int GetMenuIdByName(string name);
        AuthorizationsUI GetAuthInfoByMenuAndRole(string menuName, int roleId);
        void AddAuth(AuthorizationsUI model);
        void UpdateAuth(AuthorizationsUI model);
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(UserUI user);
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        void AddUser(UserUI user);
        /// <summary>
        /// 删除用户
        /// </summary>   
        /// <param name="id"></param>
        void DeleteUser(int id);
        /// <summary>
        /// 根据数据字典类型获取数据项
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<DataDicInfoUI> GetDataDicByType(int type);

        List<RoleUI> GetRoleNameList();

    }
}
