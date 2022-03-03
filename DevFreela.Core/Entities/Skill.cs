namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string description)
        {
            Description = Description;
            CreateAt = DateTime.Now;
        }
        public int Description { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}
