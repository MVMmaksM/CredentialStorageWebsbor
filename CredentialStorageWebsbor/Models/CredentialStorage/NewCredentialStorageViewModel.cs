namespace CredentialStorageWebsbor.Models.CredentialStorage
{
    public class NewCredentialStorageViewModel
    {
        public string Name { get; set; }
        public string OKPO { get; set; }
        public string Password { get; set; }
        public DateTime DateCreate { get; set; } = DateTime.Now;
        public string? UserCreate { get; set; }
        public string? Comment { get; set; }
    }
}
