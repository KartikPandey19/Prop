namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string? lastName { get; set; }
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

    }
}
