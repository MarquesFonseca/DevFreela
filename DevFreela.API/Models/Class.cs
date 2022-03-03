namespace Developers.API.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Developer : Person
    {
        public string Language { get; set; }
        public string Platform { get; set; }    
    }

    public class Employed
    {
        Developer developer = new Developer();
        public string ReturnEmployed()
        {
            return string.Format("Olá sou {0}, Sou desenvolvedor {1} utilizando {2}", developer.Name, developer.Language, developer.Platform);
        }
    }
}
