using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebsite.Shared.Models.Data
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
