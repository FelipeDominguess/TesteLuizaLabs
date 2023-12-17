using System.ComponentModel.DataAnnotations;

namespace TesteLuizaLabs.Data.DataModels
{
    public class CustomerModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo Nome do Cliente/Razão Social é obrigatório.")]
        [StringLength(150, ErrorMessage = "O Nome do Cliente/Razão Social deve ter no máximo 150 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo E-Mail é obrigatório.")]
        [StringLength(150, ErrorMessage = "O E-Mail deve ter no máximo 150 caracteres.")]
        [EmailAddress(ErrorMessage = "Insira um E-Mail válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Insira um número de telefone válido.")]
        public string? Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Campos relacionados a informações pessoais
        [Required(ErrorMessage = "Selecione o Tipo de Pessoa.")]
        public string? PersonType { get; set; } // Pode ser "Física" ou "Jurídica"

        [Required(ErrorMessage = "O campo CPF/CNPJ é obrigatório.")]
        [RegularExpression(@"^\d{11,14}$", ErrorMessage = "Insira um CPF ou CNPJ válido.")]
        public string? CPF_CNPJ { get; set; }

        public string? StateRegistration { get; set; } // Inscrição Estadual

        public bool IsStateRegistrationExempted { get; set; } // Campo Isento

        // Campos relacionados a pessoa física
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; } // Nullable

        // Área de Situação do Cliente
        public bool IsBlocked { get; set; }

        // Área de Senha de Acesso
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 15 caracteres.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "A confirmação de senha é obrigatória.")]
        [Compare("Password", ErrorMessage = "As senhas não conferem.")]
        public string? ConfirmPassword { get; set; }
    }
}
