namespace ResultManagementSystem.Core.Entities
{
    public class BaseEntity
    {
        public string? CreatedBy { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set;} = DateTime.Now;   
    }
}
