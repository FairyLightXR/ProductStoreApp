using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace ProductStoreApp.Models
{
    public class Manufacturers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string? Email { get; set; }
    }
}
