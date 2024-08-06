using Microsoft.EntityFrameworkCore;
using System.Data;
using Travel_Desk_Application.Data;
using Travel_Desk_Application.DTO;
using Travel_Desk_Application.Models;
using Travel_Desk_Application.RepoInterface;

namespace Travel_Desk_Application.Repository
{
    public class AdminRepoImpl : AdminInterface
    {
        private readonly ApplicationDbContext _context;

        public AdminRepoImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public Role AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public List<UserDTO> GetAllUser()
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            List<User> listUser = _context.Users.Include(u => u.Role).ToList();

            foreach (User user in listUser)
            {
                UserDTO dto = new UserDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    MobileNumber = user.MobileNumber,
                    Address = user.Address,
                    IsActive = user.IsActive,
                    RoleName = user.Role.RoleName
                };

                userDTOs.Add(dto);
            }

            return userDTOs;

        }

        public List<RoleDTO> GetAllRoles()
        {
            // Initialize an empty list to hold the RoleDTO objects.
            List<RoleDTO> roleDTOs = new List<RoleDTO>();

            // Fetch all roles from the database.
            List<Role> roles = _context.Roles.ToList();

            // Loop through each role entity.
            foreach (Role role in roles)
            {
                // Create a new RoleDTO object.
                RoleDTO dto = new RoleDTO
                {    // RoleId = role.RoleId, // but in front end we dont need to show the id
                    RoleName = role.RoleName // Assign the RoleName from the role entity.
                };

                // Add the RoleDTO object to the list.
                roleDTOs.Add(dto);
            }

            // Return the list of RoleDTO objects.
            return roleDTOs;
        }


        public Role? GetRoleByName(string roleName)
            {
                return _context.Roles.FirstOrDefault(r => r.RoleName == roleName);
            }

       public Login LoginCheck(string Email, string Password)
        {
            var user=_context.Users.FirstOrDefault(e => e.Email == Email && e.Password==Password);
            // If the user is found, return a new Login DTO with the user's email and password
            if (user != null)
            {
                return new Login
                {
                    Email = user.Email,
                    Password = user.Password
                };
            }

            // If the user is not found, return null
            return null;

        }

         public User EditUser(User user, int Id)
        {
            var obj=_context.Users.FirstOrDefault(e=> e.Id==Id);
            if (obj != null) 
                {
                obj.FirstName = user.FirstName;
                obj.LastName = user.LastName;
                obj.Email = user.Email;
                obj.Password = user.Password;
                obj.Address = user.Address;
                obj.IsActive = user.IsActive;
                if (user.Role != null && user.Role.RoleName != null)
                {
                    var role = _context.Roles.FirstOrDefault(r => r.RoleName == user.Role.RoleName);
                    if (role != null)
                    {
                        obj.RoleId = role.RoleId;
                        obj.Role = role;
                    }
                }

                _context.SaveChanges(); // Save changes to the database
            }
            return obj;

        }

        
    }
    }
    


