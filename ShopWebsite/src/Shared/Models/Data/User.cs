namespace ShopWebsite.Shared.Models.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; } = "Customer";
        public Address Address { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
