

using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Category
    {
      
        [Key]           //data annotation
        public int Id { get; set; }
      
        [Required]      //data annotation
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }=DateTime.Now; 
    }
}
