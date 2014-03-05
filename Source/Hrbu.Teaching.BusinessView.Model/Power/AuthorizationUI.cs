using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model.Power
{
    public class AuthorizationUI
    {
        public int Id { get; set; }
        public Nullable<int> MenuId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string MenuName { get; set; }
        public Nullable<bool> Enable { get; set; }
    }
}
