using PassManagerAPI.Entities;
using PassManagerAPI.Infra.Context;

namespace PassManagerAPI.Infra.Repository
{
    public interface IPassRepository
    {
        Task AddAsync(Password entity);
    }

    public class PassRepository : IPassRepository
    {
        private readonly IPassContext _context;

        public PassRepository(IPassContext context)
        {
            _context = context;
        }

        public Task AddAsync(Password entity)
        {
            _context.Passwords.Add(entity);

            return Task.CompletedTask;
        }
    }
}
