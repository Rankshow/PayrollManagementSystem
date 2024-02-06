namespace PayrollManagementSystem.Core.Entities
{
    public class Employee : Entity  
    {    
        public string Name { get; set; } = string.Empty;    
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
        public Department? Department { get; set; }
        public Salary? Salary { get; set; }    
    }
}
