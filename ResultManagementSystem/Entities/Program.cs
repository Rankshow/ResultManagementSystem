namespace ResultManagementSystem.Core.Entities
{
    public class Program : BaseEntity
    {
        public Guid ProgramId { get; set; }
        public string Type { get; set; } = string.Empty;
        public ICollection<Program>? Programs { get; set; }
    }
}
