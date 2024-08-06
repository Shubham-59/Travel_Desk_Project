using Microsoft.AspNetCore.Mvc;
using Travel_Desk_Application.DTO;
using Travel_Desk_Application.Models;
using Travel_Desk_Application.RepoInterface;

namespace Travel_Desk_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminInterface _adminInterface;

        public AdminController(AdminInterface adminInterface)
        {
            _adminInterface = adminInterface;
        }


        [HttpPost("user")]
        public IActionResult AddUser([FromBody] User user)
        {

            var addUser = _adminInterface.AddUser(user);
            return Created("Added", addUser);
        }

        [HttpPost("role")]
        public IActionResult AddRole([FromBody] Role role)
        {
            var addRole = _adminInterface.AddRole(role);
            return Created("Added", addRole);
        }

        [HttpGet("user")]
        public IActionResult GetAllUsers()
        {
            List<UserDTO> listUser = _adminInterface.GetAllUser();
            return Ok(listUser);
        }

        [HttpGet("role")]
        public IActionResult GetAllRoles()
        {
            List<RoleDTO> allRoles = _adminInterface.GetAllRoles();

            return Ok(allRoles);
        }





        [HttpPut("userupdate{Id}")]
        public IActionResult EditUser([FromBody] User user, int Id)
        {
                        User updateuser=_adminInterface.EditUser(user, Id);
                         return Ok(updateuser);
        }


        [HttpPost("logincheck")]
        public IActionResult LoginCheck(string Email, string Password)
        {
            Login login = _adminInterface.LoginCheck(Email, Password);
            if (login != null)
            {
                return Ok("Login successful");
            }
            else
            {
                return Unauthorized("Invalid email or password");
            }
        }

    }
    }

