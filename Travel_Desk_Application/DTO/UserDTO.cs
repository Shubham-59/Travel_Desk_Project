namespace Travel_Desk_Application.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
    }
}
