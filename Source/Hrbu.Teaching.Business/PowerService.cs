using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.Interface;
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
    public class PowerService:IPower
    {
        public List<DataDicUI> GetDataInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<DataDic>,List<DataDicUI>>(DataDicContext.GetDateListByPage(startPage,pageSize,out totalCount));
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
           return EntityMapping.Auto<Role,RoleUI>( RoleContext.GetRoleByRoleId(Id));
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


        public DataDicInfoUI GetDataDicInfoById(int Id)
        {
            return EntityMapping.Auto<DataDicInfo, DataDicInfoUI>(DataDicinfoContext.GetDataDicInfoById(Id));
        }


        public List<UserUI> GetUserInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            return EntityMapping.Auto<List<User>, List<UserUI>>(UserContext.GetUserListByPage(startPage, pageSize, out totalCount));

        }
    }
}
