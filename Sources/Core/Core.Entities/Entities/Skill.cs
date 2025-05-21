using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Representa uma habilidade técnica ou competência no portfólio
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// Nome da habilidade
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Nível de proficiência na habilidade (0-100)
        /// </summary>
        [Range(0, 100)]
        public int Level { get; set; } = 0;
        
        /// <summary>
        /// Tempo de experiência com a habilidade
        /// </summary>
        [Required]
        public string Duration { get; set; } = "0 months";
    }
}
