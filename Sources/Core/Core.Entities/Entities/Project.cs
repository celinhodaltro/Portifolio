using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Project
    {
        public Project(string nome, string descricao, string? link = null, string? imageUrl = null, string status = "Concluído")
        {
            Nome = nome;
            Descricao = descricao;
            Link = link;
            ImageUrl = imageUrl;
            Status = status;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string? Link { get; set; }
        public string? ImageUrl { get; set; }
        public string Status { get; set; }
    }
}
