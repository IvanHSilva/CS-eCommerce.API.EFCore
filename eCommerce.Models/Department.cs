namespace eCommerce.Models {
    public class Department {
        // Attributes
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Composition
        public ICollection<User>? Users { get; set; }

        // Constuctors
        public Department() { }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
