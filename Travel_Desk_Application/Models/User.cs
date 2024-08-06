namespace Travel_Desk_Application.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string? ModifiyedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; } = true;

        // Foreign key 
        public int RoleId { get; set; }
        // navigation property
        public virtual Role? Role { get; set; }
    }

}
