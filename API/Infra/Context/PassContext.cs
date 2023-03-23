using PassManagerAPI.Entities;

namespace PassManagerAPI.Infra.Context
{
    public interface IPassContext
    {
        IList<Password> Passwords { get; set; }
    }

    public class PassContext : IPassContext
    {
        public IList<Password> Passwords { get; set; } = new List<Password>();
    }
}
