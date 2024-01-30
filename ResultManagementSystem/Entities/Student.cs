namespace ResultManagementSystem.Core.Entities
{
    public class Student : BaseEntity
    {
        public Guid StudentId { get; set; }
        public string Name { get; set;} = string.Empty;
        public string Gender { get; set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
        public float Age { get; set;}
        public Grade? Grade { get; set; }
    }
}
