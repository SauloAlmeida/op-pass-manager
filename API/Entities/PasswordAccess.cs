using PassManagerAPI.Entities.Base;

namespace PassManagerAPI.Entities
{
    public class PasswordAccess : EntityBase
    {
        private PasswordAccess() { }

        public PasswordAccess(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public void Update(string login, string password)
        {
            Login = login;
            Password = password;
            UpdatedAt = DateTime.Now;
        }
    }
}
