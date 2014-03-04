using Hrbu.Teaching.BusinessView.Model.Power;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Hrbu.Teaching.Interface
{
    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        List<UserUI> GetUserInfoById(int Id);
        [OperationContract]
        bool GetUserByNoAndPass(string No, string password);
        [OperationContract]
        bool GetRoleByNo(string No);
        [OperationContract]
        List<string> GetAllRole();

        UserUI GetUserInfoByNo(string No);

    }
}
