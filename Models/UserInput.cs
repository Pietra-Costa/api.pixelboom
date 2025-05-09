namespace api.pixelboom.Models
{
    public class UserInput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime SessionTime { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Active { get; set; }
        public bool IsWhatsApp { get; set; }
    }
}
