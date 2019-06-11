using System.Collections.Generic;
using Nishaan.Gym.Model;
using Nishaan.Gym.ViewModel;

namespace Nishaan.Gym.Interface
{
    public interface IUsersInRoles
    {
        bool AssignRole(UsersInRoles usersInRoles);
        bool CheckRoleExists(UsersInRoles usersInRoles);
        bool RemoveRole(UsersInRoles usersInRoles);
        List<AssignRolesViewModel> GetAssignRoles();
    }
}