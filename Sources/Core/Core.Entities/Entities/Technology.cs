using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Core.Entities
{
    /// <summary>
    /// Representa uma tecnologia utilizada nos projetos do portfólio
    /// </summary>
    public class Technology
    {
        /// <summary>
        /// Nome da tecnologia
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Ícone representativo da tecnologia
        /// </summary>
        [Required]
        public string Icon { get; set; } = string.Empty;
        
        /// <summary>
        /// Cor associada à tecnologia para exibição visual
        /// </summary>
        public Color Color { get; set; }
        
        /// <summary>
        /// Anos de experiência com a tecnologia
        /// </summary>
        [Range(0, 50)]
        public int YearsExperience { get; set; }
        
        /// <summary>
        /// Descrição detalhada da tecnologia e experiência
        /// </summary>
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
