using System.ComponentModel.DataAnnotations;

namespace FilmesMoura1.WebAPI.DTO;

public class LoginDTO
{
    [Required(ErrorMessage = "O Email do usuário é obrigatório!")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "O Email do usuário é obrigatório!")]

    public string? Senha { get; set;  }

}
