using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class SysDto
    {
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
}