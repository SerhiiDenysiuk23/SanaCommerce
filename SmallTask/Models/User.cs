using System.ComponentModel.DataAnnotations;

namespace SmallTask.Models
{
    public class User
    {
        [Required(ErrorMessage = "You didn't input name")]
        public string Name { get; set; }
    }
}
