namespace eCommerce.Models {
    public class Address {
        // Attributes
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string? Comp { get; set; }
        public string District { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        // Composition
        public User? User { get; set; }

        // Constructors
        public Address() {}

        public Address(int id, int userId, string? description,
            string street, string number, string? comp, string district,
            string city, string state, string zipCode) {
            Id = id;
            UserId = userId;
            Description = description;
            Street = street;
            Number = number;
            Comp = comp;
            District = district;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
