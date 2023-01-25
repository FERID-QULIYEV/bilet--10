using TaskCode10.Models.Base;

namespace TaskCode10.Models
{
    public class Pozition:BaseId
    {
        public string Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
