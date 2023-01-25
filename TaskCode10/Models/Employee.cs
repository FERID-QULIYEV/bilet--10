using TaskCode10.Models.Base;

namespace TaskCode10.Models
{
    public class Employee:BaseId
    {
        public string Image { get; set; }
        public string FullName { get; set; }
        public int PozisionId { get; set; }
        public Pozition Pozision { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}
