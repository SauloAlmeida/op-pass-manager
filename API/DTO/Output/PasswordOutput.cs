using PassManagerAPI.Entities;

namespace PassManagerAPI.DTO.Output
{
    public class PasswordOutput
    {
        public Guid Id { get; private set; }
        public string Address { get; private set; }
        public IEnumerable<PasswordAccessOutput> Access { get; private set; } = new List<PasswordAccessOutput>();
        public DateTime CreatedAt { get; private set; }

        public static PasswordOutput FromEntity(Password entity)
        {
            return new PasswordOutput
            {
                Id = entity.Id,
                Address = entity.Address,
                Access = entity.GetAccess.Select(a => PasswordAccessOutput.FromEntity(a)),
                CreatedAt = entity.CreatedAt,
            };
        }
    }
}
