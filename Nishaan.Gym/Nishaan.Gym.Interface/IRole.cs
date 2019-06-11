using System.Collections.Generic;
using Nishaan.Gym.Model;

namespace Nishaan.Gym.Interface
{
    public interface IRole
    {
        void InsertRole(Role role);
        bool CheckRoleExits(string roleName);
        Role GetRolebyId(int roleId);
        bool DeleteRole(int roleId);
        bool UpdateRole(Role role);
        List<Role> GetAllRole();
    }
}