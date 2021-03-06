﻿using Hrbu.Teaching.BusinessView.Model.Power;
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
        List<DataDicInfoUI> GetDataDicInfoById(int Id);
        [OperationContract]
        void UpdateDataDic(DataDicInfoUI dataInfo);
        [OperationContract]
        void AddDataDic(DataDicInfoUI dataInfo);
       
    }
}
