using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDBContext
    {
        public DevFreelaDBContext()
        {
            Projects = new List<Project>()
               {
                   new Project("Meu projeto AspNet Core 1", "Minha Descricao do Projeto1", 1, 1, 10000),
                   new Project("Meu projeto AspNet Core 2", "Minha Descricao do Projeto2", 1, 1, 20000),
                   new Project("Meu projeto AspNet Core 3", "Minha Descricao do Projeto3", 1, 1, 30000)
               };

            Users = new List<User>()
            {
                new User("Marques Silva","marquesfonseca@gmail.com", Convert.ToDateTime("02/01/1986")),
                new User("Marques Fonseca","marques-fonseca@gmail.com", Convert.ToDateTime("02/01/1986")),
                new User("Marques Silva Fonseca","marquesfonseca@gmail.com", Convert.ToDateTime("02/01/1986")),
            };

            Skills = new List<Skill>()
            {
                new Skill("C#"),
                new Skill(".Net Core"),
                new Skill("SqlServer")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
