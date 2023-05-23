using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [StringLength(50, ErrorMessage = "Tamanho Maximo é 50 caracteres")]
        [Required(ErrorMessage = "Informe nome do cliente")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Tamanho Maximo é 100 caracteres")]
        public string Cidade { get; set; }
    }
}
