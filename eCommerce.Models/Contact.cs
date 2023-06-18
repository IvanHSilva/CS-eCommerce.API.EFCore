namespace eCommerce.Models {
    public class Contact {
        // Attributes
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Phone { get; set; }
        public string? CellPhone { get; set; }

        // Compositions
        public User? User { get; set; }

        // Constructor
        public Contact() { }

        public Contact(int id, int userId, string? phone, string? cellPhone) {
            Id = id;
            UserId = userId;
            Phone = phone;
            CellPhone = cellPhone;
        }
    }
}
