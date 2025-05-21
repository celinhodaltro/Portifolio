using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Representa uma experiência profissional no portfólio
    /// </summary>
    public class Experience
    {
        /// <summary>
        /// Título ou cargo da experiência
        /// </summary>
        [Required]
        public string Title { get; set; } = string.Empty;
        
        /// <summary>
        /// Detalhes adicionais sobre a experiência
        /// </summary>
        public string? Detail { get; set; }
        
        /// <summary>
        /// Nome da empresa ou organização
        /// </summary>
        [Required]
        public string Company { get; set; } = string.Empty;
        
        /// <summary>
        /// URL da imagem da empresa
        /// </summary>
        public string? CompanyImage { get; set; }
        
        /// <summary>
        /// Data de início da experiência
        /// </summary>
        [Required]
        public DateTime Start { get; set; }
        
        /// <summary>
        /// Data de término da experiência (null se for atual)
        /// </summary>
        public DateTime? End { get; set; }
        
        /// <summary>
        /// Descrição detalhada das atividades e responsabilidades
        /// </summary>
        public string? Description { get; set; }
    }
}
