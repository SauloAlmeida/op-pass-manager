namespace PassManagerAPI.DTO.Input
{
    public class PasswordAccessInput
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Login))
                throw new Exception($"The property {nameof(Login)} can't be null or empty.");

            if (string.IsNullOrEmpty(Password))
                throw new Exception($"The property {nameof(Password)} can't be null or empty.");
        }
    }
}