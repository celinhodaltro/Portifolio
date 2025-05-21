using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Representa um projeto no portfólio
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Inicializa uma nova instância da classe Project
        /// </summary>
        /// <param name="name">Nome do projeto</param>
        /// <param name="description">Descrição do projeto</param>
        /// <param name="link">Link opcional para o projeto</param>
        /// <param name="imageUrl">URL opcional da imagem do projeto</param>
        /// <param name="status">Status do projeto (padrão: "Completed")</param>
        public Project(string name, string description, string? link = null, string? imageUrl = null, string status = "Completed")
        {
            Name = name;
            Description = description;
            Link = link;
            ImageUrl = imageUrl;
            Status = status;
        }

        /// <summary>
        /// Nome do projeto
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Descrição detalhada do projeto
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Link opcional para o projeto (repositório, demonstração, etc.)
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// URL opcional da imagem do projeto
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Status atual do projeto
        /// </summary>
        [Required]
        public string Status { get; set; }
    }
}
