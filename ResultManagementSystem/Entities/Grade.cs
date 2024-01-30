namespace ResultManagementSystem.Core.Entities
{
    public class Grade
    {
        public Guid GradeId { get; set; }
        public string Type { get; set; } = string.Empty;
        public ICollection<Student>? Students { get; set; }
    }
}
