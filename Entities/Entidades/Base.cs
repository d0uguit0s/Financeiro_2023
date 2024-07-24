using Entities.Notificacoes;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entidades;
public class Base : Notifica
{
    [Display(Name = "Código")]
    public Guid Id { get; set; }

    [Display(Name = "Name")]
    public string Nome { get; set; }
}
