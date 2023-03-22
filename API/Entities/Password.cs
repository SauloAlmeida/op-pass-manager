using PassManagerAPI.Entities.Base;

namespace PassManagerAPI.Entities
{
    public class Password : EntityBase
    {
        private Password() { }

        public Password(string address, IEnumerable<PasswordAccess> access)
        {
            Address = address;
            Access = access.ToList();
        }

        public string Address { get; private set; }

        private IList<PasswordAccess> Access { get; set; } = new List<PasswordAccess>();
        public IEnumerable<PasswordAccess> GetAccess => Access.AsReadOnly();

        public void Update(string address)
        {
            Address = address;
            UpdatedAt = DateTime.Now;
        }

        public void AddAccess(PasswordAccess access)
        {
            Access.Add(access);
            UpdatedAt = DateTime.Now;
        }

        public void RemoveAccess(Guid id)
        {
            var access = Access.FirstOrDefault(w => w.Id == id);

            if (access is null) return;

            Access.Remove(access);
            UpdatedAt = DateTime.Now;
        }

        public void UpdateAccess(PasswordAccess entity)
        {
            var index = Access.IndexOf(entity);

            if (index is -1) return;

            Access[index] = entity;
            UpdatedAt = DateTime.Now;
        }
    }
}
