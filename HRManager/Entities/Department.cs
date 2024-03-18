namespace HRManager.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public Department()
        {
            Users = new List<HRManagerUser>();
        }

        public string Name { get; set; } = "";

        public string? Description { get; set; }

        public virtual ICollection<HRManagerUser> Users { get; set; }
    }
}
