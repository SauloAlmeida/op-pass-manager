using PassManagerAPI.Entities;

namespace PassManagerAPI.DTO.Output
{
    public class PasswordAccessOutput
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static PasswordAccessOutput FromEntity(PasswordAccess entity)
        {
            return new PasswordAccessOutput
            {
                Id = entity.Id,
                Login = entity.Login,
                Password = entity.Password
            };
        }
    }
}