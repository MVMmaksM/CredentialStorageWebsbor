namespace CredentialStorageWebsbor.Models.Websbor
{
    public class EditWebsborViewModel
    {
        public EditWebsborViewModel(int id)
        {
            Id = id.ToString();
        }
        public string Id { get; set; }
        public string FullName { get; set; } = "Test";
        public string ShortName { get; set; } = "Test";
        public string OKPO { get; set; } = "156465";
        public long? OKATOfact { get; set; } = 3700005; 
        public long? OKATOreg { get; set; } = 37051515;
        public string? OKVED2fact { get; set; } = "37.14";
        public string? Address { get; set; } = "Test";
        public long? INN { get; set; } = 450000;
        public long? OGRN { get; set; } = 4505465;
        public string? Phone { get; set; } = "89003795411";
        public string? Email { get; set; } = "mail";
    }
}
