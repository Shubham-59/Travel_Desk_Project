    namespace Travel_Desk_Application.Models
    {
        public class Role
        {
            public int RoleId { get; set; }
            public string RoleName{ get; set; }
            public int CreatedBy { get; set; }
            public DateTime CreatedOn { get; set; } = DateTime.Now;
            public string? ModifiyedBy { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public bool IsActive { get; set; } = true;


        // one to Many relatioship 
        //This means that one Role can be associated with multiple User objects,
        //but each User can be associated with only one Role
        public virtual ICollection<User>? Users { get; set; }  
    }
    }
