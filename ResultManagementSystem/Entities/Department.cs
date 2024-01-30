namespace ResultManagementSystem.Core.Entities
{
    public class Department : BaseEntity
    {
        public Guid DepartmentId { get; set; }
        public string Type { get; set; } = string.Empty;
        public ICollection<Grade>? Grades { get; set; }

    }
}
