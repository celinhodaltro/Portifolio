using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Representa um curso ou certificado obtido por uma pessoa
    /// </summary>
    public class Course : Model
    {
        /// <summary>
        /// Inicializa uma nova instância da classe Course
        /// </summary>
        public Course() { }

        /// <summary>
        /// Fonte ou instituição do curso
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Descrição detalhada do curso
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// ID da pessoa associada ao curso
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Pessoa associada ao curso
        /// </summary>
        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }
    }
}
