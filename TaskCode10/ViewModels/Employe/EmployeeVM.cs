using TaskCode10.Models;

namespace TaskCode10.ViewModels
{
    public class EmployeeVM
    {
        public IFormFile Image { get; set; }
        public string FullName { get; set; }
        public int PozisionId { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}
