using System.ComponentModel.DataAnnotations;

namespace RegistrationAPI.Entities {
    public class Clinic {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}