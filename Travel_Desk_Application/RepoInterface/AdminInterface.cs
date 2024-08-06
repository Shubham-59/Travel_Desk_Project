using Travel_Desk_Application.DTO;
using Travel_Desk_Application.Models;

namespace Travel_Desk_Application.RepoInterface
{
    public interface AdminInterface
    {
        public Role AddRole(Role role);
        public User AddUser(User user);
        List<UserDTO> GetAllUser();

        List<RoleDTO> GetAllRoles();
        Role? GetRoleByName(string roleName);
        Login LoginCheck(string Email,string Password);

        User EditUser(User user, int Id);
    }
}
