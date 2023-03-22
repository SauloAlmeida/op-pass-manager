namespace PassManagerAPI.Entities.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
