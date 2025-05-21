using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

/// <summary>
/// Representa uma pessoa no portfólio
/// </summary>
public class Person : Model
{
    /// <summary>
    /// Nome da pessoa
    /// </summary>
    [Required]
    public string Name { get; set; } = string.Empty;
}
