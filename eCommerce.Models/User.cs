using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    [Table("Usuarios")]
    public class User {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("Nome")]
        public string Name { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        [Column("Senha")]
        public string Password { get; set; } = string.Empty;
        [Column("Sexo")]
        public string? Gender { get; set; }
        public string? RG { get; set; }
        public string? CPF { get; set; }
        [Column("Filiacao")]
        public string? Filiation { get; set; }
        [Column("Situacao")]
        public string? Situation { get; set; }
        [Column("DataCad")]
        public DateTime RegDate { get; set; }

        // Composition
        public Contact? Contact { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Department>? Departments { get; set; }

        // Constructors
        public User() { }

        public User(int id, string name, string eMail, string? gender, 
            string? rg, string? cpf, string? filiation, string? situation, 
            DateTime regDate) {
            Id = id;
            Name = name;
            EMail = eMail;
            Gender = gender;
            RG = rg;
            CPF = cpf;
            Filiation = filiation;
            Situation = situation;
            RegDate = regDate;
        }
    }
}
