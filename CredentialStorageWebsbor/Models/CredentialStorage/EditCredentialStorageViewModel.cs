namespace CredentialStorageWebsbor.Models.CredentialStorage
{
    public class EditCredentialStorageViewModel
    {
        public EditCredentialStorageViewModel(int id)
        {
            Id = id.ToString();
        }
        public string Id { get; set; } = "1";
        public string Name { get; set; } = "Test";
        public string OKPO { get; set; } = "123456";
        public string Password { get; set; } = "sdf(*(&832d";
        public string? DateCreate { get; set; } = DateTime.Now.ToString();
        public string? UserCreate { get; set; } = "Test";
        public string? UserUpdate { get; set; } = "Test";
        public string? DateUpdate { get; set; } = "Test";
        public string? Comment { get; set; } = "Test";
    }
}
