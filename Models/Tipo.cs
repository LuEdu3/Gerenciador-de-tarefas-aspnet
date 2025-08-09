using System.ComponentModel.DataAnnotations;
namespace app_tarefas.Models;

public class Tipo
{
    [Key]
    public int id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MinLength(2, ErrorMessage = "Mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "O campo Descrição é obrigatório")]
    [MinLength(2, ErrorMessage = "Mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
    public string Descricao { get; set; } = null!;
}