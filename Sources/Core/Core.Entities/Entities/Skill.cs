using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 0;
        public string Duration { get; set; } = "0 months";  // Adicionando a propriedade de duração
    }

}
